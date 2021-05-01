using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Webhook;
using Fusion;

namespace HomeServices.Helpers.Discord
{
    public class WebhookTool
    {
        private static string PictureURL = "https://cdn.discordapp.com/attachments/837405616335093859/837405624898945054/log.png";

        private static async Task<string> WebhookURL()
        {
            return await FusionApp.GetAppVar("DiscordWebhook");
        }

        public struct HookModule
        {
            public bool Error { get; set; }
        }

        private static Random rnd = new Random();

        public static async Task<HookModule> Ticket (string message, string title)
        {
            try
            {
                var webobj = new WebhookObject();
                webobj.content = "@everyone";
                var embed = new Embed
                {
                    author = new Author { name = "HomeServices - Ticket" },
                    thumbnail = new Thumbnail { url = PictureURL},
                    description = $"**Username:** {User.Username}\n**User ID:** {User.UserId}\n\n**Title:** {title}\n\n**Message:** {message}",
                    footer = new Footer { text = $"Tickets powered by HoverCore | hovercore.cc" },
                    Color = new DColor(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255)),
                };
                webobj.embeds.Add(embed);
                await new Webhook(await WebhookURL()).SendAsync(webobj);
                return new HookModule { Error = false };
            }
            catch
            {
                return new HookModule
                {
                    Error = true
                };
            }
        }
    }
}
