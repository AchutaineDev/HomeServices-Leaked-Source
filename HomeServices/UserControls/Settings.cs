using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void AutoLoginCheck_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AutoLogin = AutoLoginCheck.Checked;
            settings.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            AutoLoginCheck.Checked = settings.AutoLogin;
            DiscordCheck.Checked = settings.ShowDiscordRPC;
            apptopmost.Checked = settings.AppTopMost;
        }

        private void DiscordCheck_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.ShowDiscordRPC = DiscordCheck.Checked;
            settings.Save();
            infolabel.Visible = true;
        }

        private void apptopmost_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.AppTopMost = apptopmost.Checked;
            settings.Save();
        }
    }
}
