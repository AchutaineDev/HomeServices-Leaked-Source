using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Fusion;
using System.Diagnostics;

namespace HomeServices.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            welcomelabelk.Text = $"Welcome to Home Services, {User.Username}";
            AppVersion.Text = await FusionApp.GetAppVar("AppVersion");
            AnnouncementBox.Text = await FusionApp.GetAppVar("AnnouncementText");
            LastUpdateLabel.Text = await FusionApp.GetAppVar("AnnouncementUpdate");
            totaluserslabel.Text = App.UserCount;
            totaltools.Text = await FusionApp.GetAppVar("TotalTools");
            apcountlabel.Text = App.ApiCount;
            userdetails.Text = User.Username;
            exdate.Text = User.Expiry;
            switch (User.Level)
            {
                case 1:
                    planname.Text = "Bronze";
                    break;
                case 2:
                    planname.Text = "Silver";
                    break;
                case 3:
                    planname.Text = "Gold";
                    break;
                case 4:
                    planname.Text = "Platinum";
                    break;
                case 5:
                    planname.Text = "Developer";
                    break;
                default:
                    planname.Text = "Error";
                    break;
            }
        }

        private async void YoutubeBTN_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("YouTubeLink")); } catch { }
        }

        private async void WebsiteLinkBTn_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("WebSiteLink")); } catch { }
        }

        private async void DiscordLinkBTn_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("DiscordLink")); } catch { }
        }

        private async void InstagramlibkBTN_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("InstagramLink")); } catch { }
        }
    }
}
