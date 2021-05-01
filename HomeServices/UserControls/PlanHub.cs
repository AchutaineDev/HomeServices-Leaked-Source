using Fusion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices.UserControls
{
    public partial class PlanHub : UserControl
    {
        public PlanHub()
        {
            InitializeComponent();
        }

        private async void SendBTN_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("DiscordLink")); } catch { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SendBTN_Click(null, null);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SendBTN_Click(null, null);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SendBTN_Click(null, null);
        }
    }
}
