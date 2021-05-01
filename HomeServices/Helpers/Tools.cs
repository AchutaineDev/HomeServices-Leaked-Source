using Fusion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeServices.Helpers
{
    public class Tools
    {
        public static bool IsAuthCheckOk;

        public static void AddNewAttackLog(string Target, string Port, string Time, string Method)
        {
            var Setting = SettingsManager.Load();

            Setting.Target += Target + Environment.NewLine;
            Setting.Port += Port + Environment.NewLine;
            Setting.Time += Time + Environment.NewLine;
            Setting.Method += Method + Environment.NewLine;
            Setting.SentAt += DateTime.Now.ToString() + Environment.NewLine;
            Setting.TotalAttacks++;
            Setting.Save();
        }
        public static string CurrentVersion = "1.0.0";

        public static async Task CheckForUpdate()
        {
            var resp = await FusionApp.GetAppVar("AppVersion");
            if (!resp.Contains("Invalid Var"))
            {
                if (!resp.Contains(CurrentVersion))
                {
                    Alert.Show("Update available", "There is a new update available for home services please download the new one");
                    Process.Start(await FusionApp.GetAppVar("UpdateLink"));
                    Environment.Exit(0);
                }
            }
        }
        public static void CheckToMuch()
        {
            var Setting = SettingsManager.Load();

            if (Setting.TotalAttacks >= 100)
            {
                ClearAllAttackLogs();
                MessageBox.Show("Attack logs cleared\nReason: Over 100 logs");
            }
        }

        public static void ClearAllAttackLogs()
        {
            var Setting = SettingsManager.Load();

            Setting.Target = string.Empty;
            Setting.Port = string.Empty;
            Setting.Time = string.Empty;
            Setting.Method = string.Empty;
            Setting.SentAt = string.Empty;
            Setting.Save();
        }

        //  ---- Network Tools ---- \\
        //  ---- By HoverCore  ---- \\

        public static async Task<string> GeoLocateAsync (string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Warning: Host in null";

            var response = await Client.Http.Get($"http://ip-api.com/json/{host}?fields=66846719");
            if (!response.Error)
            {
                var json = JsonConvert.DeserializeObject<Client.JsonModule.GeoIP>(response.Response);
                if (json.Status == "success")
                {
                    return $"Host: {json.Query}\nContinent: {json.Continent}\nCountry: {json.Country}\nCity: {json.City}\nISP: {json.Isp}\nORG: {json.Org}\nAS: {json.As}\nTimezone: {json.Timezone}\nCurrency: {json.Currency}\nMoblile: {json.Mobile}\nHosting: {json.Hosting}\nProxy: {json.Proxy}";
                }
                else
                {
                    return $"Info: {json.Status}\nMessage: {json.Message}\nQuery: {json.Query}";
                }
            }
            else
            {
                return $"Error: {response.Exception.Message}";
            }
        }

        public static string CheckOpenPort(string host, string port)
        {
            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(port)) return "Your missing host or port";

            try
            {
                var client = new TcpClient();
                if (client.ConnectAsync(host, Convert.ToInt32(port)).Wait(500))
                {
                    return $"Port {port} is open on {host}";
                }
                else
                {
                    return $"Port {port} is closed on {host}";
                }
            }
            catch { return "Error happend, try again"; }
        }

        public static async Task<string> NmapScan(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Client.Http.Get($"https://api.hackertarget.com/nmap/?q={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }

        public static async Task<string> ZoneLookup(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain)) return "Domain is null";

            var response = await Client.Http.Get($"https://api.hackertarget.com/zonetransfer/?q={domain}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }

        public static async Task<string> SubnetScan(string host)
        {
            if (string.IsNullOrWhiteSpace(host)) return "Host is null";

            var response = await Client.Http.Get($"https://api.hackertarget.com/subnetcalc/?q={host}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }

        public static async Task<string> DnsLookup(string domain)
        {
            if (string.IsNullOrWhiteSpace(domain)) return "Domain is null";

            var response = await Client.Http.Get($"https://api.hackertarget.com/dnslookup/?q={domain}");
            if (!response.Error) return response.Response;
            else return response.Exception.Message;
        }
    }
}
