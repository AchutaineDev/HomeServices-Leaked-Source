using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module = HomeServices.Helpers.Client.JsonModule.Modules;

namespace HomeServices.Helpers.Client
{
    public class Http
    {
        private static HttpClient _client = new HttpClient();

        public static async Task<Module> Get(string uri)
        {
            try
            {
                var resp = await _client.GetAsync(uri);
                return new Module
                {
                    Error = false,
                    Response = await resp.Content.ReadAsStringAsync(),
                    Exception = null
                };
            }
            catch (Exception exception)
            {
                return new Module
                {
                    Error = true,
                    Response = "Response was not vaild",
                    Exception = exception
                };
            }
        }
    }
}
