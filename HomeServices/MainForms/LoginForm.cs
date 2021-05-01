using Fusion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeServices.MainForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static FusionApp App = new FusionApp("1089267");

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            if (settings.RemeberMe)
            {
                username.Text = settings.Username;
                password.Text = settings.Password;
                Remebermecheck.Checked = true;
            }

            Size = new Size(452, 537);
            RegistePanel.Location = new Point(24, 117);

            base.TopMost = settings.AppTopMost;

            if (settings.AutoLogin) LoginBTN_Click(null, null);

            //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            //               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void ShowRegBTN_Click(object sender, EventArgs e)
        {
            Ani.Show(RegistePanel);
        }

        private void ShowLoginBTN_Click(object sender, EventArgs e)
        {
            Ani.Hide(RegistePanel);
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            if (LoginBTN.Text != "Login") return;

            LoginBTN.Text = "Signing you in...";
            var resp = await App.Login(username.Text, password.Text);
            if (!resp.Error)
            {
                var settings = SettingsManager.Load();
                settings.Username = username.Text;
                settings.Password = password.Text;
                settings.RemeberMe = Remebermecheck.Checked;
                settings.Save();
                await Helpers.Tools.CheckForUpdate();
                Hide();
                new MainForm().Show();
            }
            else
            {
                LoginBTN.Text = "Login";
                Alert.Show("Login Error", resp.Message);
            }
        }

        private async void RegisterBTN_Click(object sender, EventArgs e)
        {
            if (RegisterBTN.Text != "Register") return;

            RegisterBTN.Text = "Checking...";
            var resp = await App.Register(Reguser.Text, Regpass.Text, Regtoken.Text);
            if (!resp.Error)
            {
                username.Text = Reguser.Text;
                password.Text = Regpass.Text;
                Alert.Show("Register successful", resp.Message);
            }
            else
            {
                RegisterBTN.Text = "Register";
                Alert.Show("Register Error", resp.Message);
            }
        }
    }
}
