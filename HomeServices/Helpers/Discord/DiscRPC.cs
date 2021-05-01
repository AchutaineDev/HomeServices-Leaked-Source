using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Helpers.Discord
{
    public class DiscRPC
    {
        public static async void LoadRpc()
        {
            var client = new DiscordRpcClient("837255939023175711");

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                State = "Version: 1.0.0",
                Details = $"Connected as {Fusion.User.Username}",
                Timestamps = Timestamps.Now,
                Buttons = new Button[]
                    {
                          new Button() { Label = "Discord Server", Url = await Fusion.FusionApp.GetAppVar("DiscordLink") },
                    },
                Assets = new Assets { LargeImageKey = "logo", LargeImageText = "Home Services" }
            }) ;
        }

        public static void StopDiscordRPC()
        {
            if (client == null) return;
            else client.Dispose();
        }

        public static DiscordRpcClient client;
    }
}
