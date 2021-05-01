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
using HomeServices.UserControls;
using Fusion;

namespace HomeServices.MainForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static FusionApp App = new FusionApp("1089267");

        private void Log(string value)
        {
            OutputBox.AppendText($"[{DateTime.Now}]  " + value + Environment.NewLine);
        }

        public async Task StartAuthCheck()
        {
            CheckTimer.Stop();
            OutputBox.Clear();
            CloseCheckBTN.Enabled = false;
            Log("Starting Check...");
            var settings = SettingsManager.Load();
            Log("Checking user on auth");
            var loginresp = await App.Login(settings.Username, settings.Password);
            Log("Trying to login user");
            if (loginresp.Error)
            {
                Helpers.Tools.IsAuthCheckOk = false;
                Log("Auth returned an error");
                Log($"Auth responded with: {loginresp.Message}");
                Log("Application restart required");
                Log("Check finished");
            }
            else
            {
                Helpers.Tools.IsAuthCheckOk = true;
                Log("Auth successfully returned a vaild response");
                Log($"Auth responded with: {loginresp.Message}");
                await Helpers.Tools.CheckForUpdate();
                Log("Loading user data");
                Log($"Username: {User.Username} - Level: {User.Level} - Expiry: {User.Expiry}");
                Log("User data loaded");

                Log("Refreshing application information");
                await FusionApp.RefreshApp();
                Log("Successfully restarted application information");

                Log("Checking ticket blacklist");
                var resp = await FusionApp.GetAppVar("TicketBlacklist");
                if (resp.Contains("Invalid Var"))
                {
                    Log("Auth returned an error");
                    Log("Unable to load the data");
                    Log("Check finished");
                    CloseCheckBTN.Enabled = true;
                }
                else if (resp.Contains(User.UserId))
                {
                    Log("Auth successfully returned a vaild response");
                    Log("You have been blacklisted from tickets");
                    Log("Check finished");
                    CloseCheckBTN.Enabled = true;
                }
                else
                {
                    Log("Auth successfully returned a vaild response");
                    Log("You are not blacklisted from tickets");
                    Log("Check finished");
                    CloseCheckBTN.Enabled = true;
                }
            }
        }

        private void SetSideBar(Guna.UI2.WinForms.Guna2Button button)
        {
            foreach (var btn in ButtonPanel.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                if (button == btn)
                {
                    btn.FillColor = Color.FromArgb(56, 20, 166);
                }
                else
                {
                    btn.FillColor = Color.FromArgb(20, 20, 20);
                }
            }
        }

        private void LoadSettings()
        {
            var settings = SettingsManager.Load();

            base.TopMost = settings.AppTopMost;

            if (settings.ShowDiscordRPC)
            {
                Helpers.Discord.DiscRPC.LoadRpc();
            }
            else
            {
                Helpers.Discord.DiscRPC.StopDiscordRPC();
            }
        }

        private void LoadControl(UserControl userControl)
        {
            MainPanel.Visible = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            Trans.Show(MainPanel);
            LoadSettings();
        }

        private void ShowHomeBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Home Page";
            LoadControl(new HomePage());
        }

        private void ShowAttackBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Attack Hub";
            LoadControl(new AttackHub());
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await Helpers.Tools.CheckForUpdate();
            Helpers.Tools.IsAuthCheckOk = true;
            LoadControl(new HomePage());
            Helpers.Tools.CheckToMuch();
            CheckTimer.Start();
        }

        private void ShowIPToolsBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "IP ToolBox";
            LoadControl(new IPToolBox());
        }

        private void ExtraToolsBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Extra Tools";
            LoadControl(new ExtraTools());
        }

        private void ShowDiscordBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Discord Tools";
            LoadControl(new DiscordTools());
        }

        private void MinmizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowMenuBTN_Click(object sender, EventArgs e)
        {
            if (DotsPanel.Visible) Ani.Hide(DotsPanel);
            else Ani.Show(DotsPanel);
        }

        private async void OpenDiscordBTN_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("DiscordLink")); } catch { }
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (DotsPanel.Visible) Ani.Hide(DotsPanel);
        }

        private void ShowTicketBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Ticket Hub";
            LoadControl(new TicketHub());
        }

        private void ShowPlansBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Plan Hub";
            LoadControl(new PlanHub());
        }

        private void SettitsBTN_Click(object sender, EventArgs e)
        {
            SetSideBar((Guna.UI2.WinForms.Guna2Button)sender);
            StateLabel.Text = "Settings";
            LoadControl(new Settings());
        }

        private async void LogoBTN_Click(object sender, EventArgs e)
        {
            try { Process.Start(await FusionApp.GetAppVar("DiscordLink")); } catch { }
        }

        private async void CheckTimer_Tick(object sender, EventArgs e)
        {
            if (Helpers.Tools.IsAuthCheckOk)
            {
                SafeCheckPanel.Visible = true;
                SafeCheckPanel.BringToFront();
                ButtonPanel.Enabled = false;
                await StartAuthCheck();
                DotsPanel.BringToFront();
            }
            else CheckTimer.Stop();
        }

        private void CloseCheckBTN_Click(object sender, EventArgs e)
        {
            SafeCheckPanel.Visible = false;
            SafeCheckPanel.SendToBack();
            ButtonPanel.Enabled = true;
            CheckTimer.Start();
        }
    }
}
