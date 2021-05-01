using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices
{
    public class SettingsModel
    {
        public SettingsModel()
        {

        }

        // Login Saving
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemeberMe { get; set; }

        // Attack Logs
        public string Target { get; set; }
        public string Port { get; set; }
        public string Time { get; set; }
        public string Method { get; set; }
        public string SentAt { get; set; }
        public int TotalAttacks { get; set; }

        // Settings
        public bool ShowDiscordRPC { get; set; } = true;
        public bool AutoLogin { get; set; } = false;
        public bool AppTopMost { get; set; } = false;

    }
}
