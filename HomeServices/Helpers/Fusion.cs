using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusion
{
    public struct FusionApp
    {
        private static HttpClient client = null;
        private static string baseUrl = null;
        private static string session;
        private static readonly string url = "https://fusionapi.dev/";

        public FusionApp(string app)
        {
            if (client == null)
            {
                var handler = new HttpClientHandler() { Proxy = null };
                client = new HttpClient(handler);
                baseUrl = $"{url}app/{app}/api";
            }
        }

        public async static Task RefreshApp()
        {
            var appBlobDictionary = new Dictionary<string, string>
            {
                { "action", "appblob" },
                { "session", session }
            };

            var appBlobSource = new FormUrlEncodedContent(appBlobDictionary);
            var appBlobResponse = await client.PostAsync(baseUrl, appBlobSource);
            var appBlobContent = await appBlobResponse.Content.ReadAsStringAsync();
            var appObject = JsonConvert.DeserializeObject<AppRoot>(appBlobContent);

            App.ActiveApis = appObject.Blob.ActiveApi;
            App.ApiCount = appObject.Blob.ApiCount;
            App.UserCount = appObject.Blob.UserCount;
            App.AppName = appObject.Blob.Label;
            App.AppDescription = appObject.Blob.Description;
        }
       
        public static string GetHwid()
        {
            return WindowsIdentity.GetCurrent().User.Value;
        }

        public async Task<FusionResponse> Login(string username, string password)
        {

            var loginDictionary = new Dictionary<string, string>
            {
                { "action", "login" },
                { "username", username },
                { "password", password }
            };

            var loginSource = new FormUrlEncodedContent(loginDictionary);
            var loginResponse = await client.PostAsync(baseUrl, loginSource);
            var loginContent = await loginResponse.Content.ReadAsStringAsync();

            try
            {
                var resp = JsonConvert.DeserializeObject<FusionResponse>(loginContent);
                if (resp.Error)
                    return resp;

                session = resp.Session;

                var userBlobDictionary = new Dictionary<string, string>
                {
                    { "action", "myblob" },
                    { "session", resp.Session }
                };
                var userBlobSource = new FormUrlEncodedContent(userBlobDictionary);
                var userBlobResponse = await client.PostAsync(baseUrl, userBlobSource);
                var userBlobContent = await userBlobResponse.Content.ReadAsStringAsync();
                var userObject = JsonConvert.DeserializeObject<UserRoot>(userBlobContent);

                string expdate;
                try { expdate = DateTimeOffset.FromUnixTimeSeconds((long)Convert.ToDouble(userObject.Blob.Expiry)).DateTime.ToString(); } catch { expdate = "Lifetime"; }

                User.MfaCode = userObject.Blob.TwoFactorCode;
                User.Ip = "1.1.1.1";
                User.HardwareId = GetHwid();
                User.Level = userObject.Blob.Level;
                User.Expiry = expdate;
                User.UserId = userObject.Blob.UserId;
                User.Username = username;

                var appBlobDictionary = new Dictionary<string, string>
                {
                    { "action", "appblob" },
                    { "session", resp.Session }
                };
                var appBlobSource = new FormUrlEncodedContent(appBlobDictionary);
                var appBlobResponse = await client.PostAsync(baseUrl, appBlobSource);
                var appBlobContent = await appBlobResponse.Content.ReadAsStringAsync();
                var appObject = JsonConvert.DeserializeObject<AppRoot>(appBlobContent);

                App.ActiveApis = appObject.Blob.ActiveApi;
                App.ApiCount = appObject.Blob.ApiCount;
                App.UserCount = appObject.Blob.UserCount;
                App.AppName = appObject.Blob.Label;
                App.AppDescription = appObject.Blob.Description;

                var response = await GetUserVar("HWID");
                if (response.Error)
                {
                    await SetUserVar("HWID", GetHwid());
                }
                else if (response.Response != GetHwid())
                {
                    return new FusionResponse { Error = true, Message = "Invalid User Hwid" };
                }

                return resp;
            }
            catch (JsonReaderException)
            {
                return new FusionResponse { Error = true, Message = "Response Was Not Valid" };
            }
        }
        public async Task<FusionResponse> Register(string username, string password, string token)
        {
            var registerDictionary = new Dictionary<string, string>
            {
                { "action", "register" },
                { "token", token },
                { "username", username },
                { "password", password }
            };

            var registerSource = new FormUrlEncodedContent(registerDictionary);
            var registerResponse = await client.PostAsync(baseUrl, registerSource);
            var registerContent = await registerResponse.Content.ReadAsStringAsync();

            try
            {
                var resp = JsonConvert.DeserializeObject<FusionResponse>(registerContent);
                if (!resp.Error) session = resp.Session;

                return resp;
            }
            catch (JsonReaderException)
            {
                return new FusionResponse { Error = true, Message = "Response Was Not Valid" };
            }
        }
        public static async Task<FusionResponse> ResetPassword(string oldpassword, string newpassword)
        {
            var changePassDictionary = new Dictionary<string, string>
            {
                { "action", "change-pass" },
                { "session", session },
                { "oldpassword", oldpassword },
                { "newpassword", newpassword }
            };

            var changePassSource = new FormUrlEncodedContent(changePassDictionary);
            var changePassResponse = await client.PostAsync(baseUrl, changePassSource);
            var changePassContent = await changePassResponse.Content.ReadAsStringAsync();

            try
            {
                var changePassJson = JsonConvert.DeserializeObject<FusionResponse>(changePassContent);
                return changePassJson;
            }
            catch (JsonReaderException)
            {
                return new FusionResponse { Error = true, Message = "Response Was Not Valid" };
            }
        }
        public static async Task<VarModule> GetUserVar(string var)
        {
            var getUserVarDictionary = new Dictionary<string, string>
            {
                { "action", "myvars" },
                { "session", session }
            };

            var getUserVarSource = new FormUrlEncodedContent(getUserVarDictionary);
            var getUserVarResponse = await client.PostAsync(baseUrl, getUserVarSource);
            var getUserVarContent = await getUserVarResponse.Content.ReadAsStringAsync();

            try
            {
                var varObject = JsonConvert.DeserializeObject<VarRoot>(getUserVarContent);
                return new VarModule
                {
                    Error = false,
                    Response = varObject.Vars[var]
                };
            }
            catch
            {
                return new VarModule
                {
                    Error = true,
                    Response = "Invalid Var"
                };
            }
        }
        public static async Task SetUserVar(string key, string value)
        {
            var setUserVarDictionary = new Dictionary<string, string>
            {
                { "action", "set-user-vars" },
                { "session", session },
                { "key", key },
                { "value", value }
            };

            var setUserVarSource = new FormUrlEncodedContent(setUserVarDictionary);
            var setUserVarResponse = await client.PostAsync(baseUrl, setUserVarSource);
            await setUserVarResponse.Content.ReadAsStringAsync();
        }
        public static async Task<string> GetAppVar(string var)
        {
            var getAppVarDictionary = new Dictionary<string, string>
            {
                { "action", "get-app-vars" },
                { "session", session }
            };

            var getAppVarSource = new FormUrlEncodedContent(getAppVarDictionary);
            var getAppVarResponse = await client.PostAsync(baseUrl, getAppVarSource);
            var getAppVarContent = await getAppVarResponse.Content.ReadAsStringAsync();

            try
            {
                var varObject = JsonConvert.DeserializeObject<VarRoot>(getAppVarContent);
                return varObject.Vars[var];
            }
            catch
            {
                return "Invalid Var";
            }
        }
        
        public static async Task<FusionResponse> ExecuteFullAPI(string id, string data, int time)
        {
            var executeApiDictionary = new Dictionary<string, string>
            {
                { "data", data },
                { "time", time.ToString() },
                { "session", session }
            };

            var executeApiSource = new FormUrlEncodedContent(executeApiDictionary);
            var executeApiResponse = await client.PostAsync($"{url}executeapi/{id}", executeApiSource);
            var executeApiContent = await executeApiResponse.Content.ReadAsStringAsync();

            try
            {
                var resp = JsonConvert.DeserializeObject<FusionResponse>(executeApiContent);
                return resp;
            }
            catch (JsonReaderException)
            {
                return new FusionResponse { Error = true, Message = "Response Was Not Valid" };
            }
        }
    }

    public class MessageRoot
    {
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
    }
    public class ManageMessageResponse
    {
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
    }
    public class AppBlob
    {
        [JsonProperty("activeapis")] public string ActiveApi { get; set; }
        [JsonProperty("apicount")] public string ApiCount { get; set; }
        [JsonProperty("usercount")] public string UserCount { get; set; }
        [JsonProperty("label")] public string Label { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
    }
    public class AppRoot
    {
        [JsonProperty("blob")] public AppBlob Blob { get; set; }
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
    }

    public class UserLog
    {
        [JsonProperty("ip")] public string Ip { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
        [JsonProperty("time")] public string Time { get; set; }
    }
    public class UserBlob
    {
        [JsonProperty("2fa-code")] public string TwoFactorCode { get; set; }
        [JsonProperty("expiry")] public string Expiry { get; set; }
        [JsonProperty("ip")] public string Ip { get; set; }
        [JsonProperty("level")] public int Level { get; set; }
        [JsonProperty("logs")] public List<UserLog> Logs { get; set; }
        [JsonProperty("uid")] public string UserId { get; set; }
        [JsonProperty("using2fa")] public bool Using2fa { get; set; }
    }
    public class UserRoot
    {
        [JsonProperty("blob")] public UserBlob Blob { get; set; }
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
    }

    public class VarModule
    {
        public bool Error { get; set; }
        public string Response { get; set; }
    }

    public struct VarRoot
    {
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
        [JsonProperty("vars")] public Dictionary<string, string> Vars { get; set; }
    }

    public struct FusionResponse
    {
        [JsonProperty("error")] public bool Error { get; set; }
        [JsonProperty("session")] public string Session { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
        [JsonProperty("response")] public string Response { get; set; }
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("blob")] public string Blob { get; set; }
    }

    public struct App
    {
        public static string ActiveApis;
        public static string ApiCount;
        public static string UserCount;
        public static string AppName;
        public static string AppDescription;
    }
    public struct User
    {
        public static bool ValidateTwoFactor = false;
        public static string MfaCode;
        public static string Ip;
        public static string HardwareId;
        public static int Level;
        public static string Expiry;
        public static string Username;
        public static string UserId;
    }
}