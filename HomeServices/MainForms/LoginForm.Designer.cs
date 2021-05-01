
namespace HomeServices.MainForms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TitleBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Remebermecheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.RegistePanel = new System.Windows.Forms.Panel();
            this.ShowLoginBTN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Regtoken = new Guna.UI2.WinForms.Guna2TextBox();
            this.Regpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Reguser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowRegBTN = new System.Windows.Forms.Label();
            this.Ani = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.TitleBarPanel.SuspendLayout();
            this.RegistePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TitleBarPanel.Controls.Add(this.ExitBTN);
            this.Ani.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.ShadowDecoration.Parent = this.TitleBarPanel;
            this.TitleBarPanel.Size = new System.Drawing.Size(899, 50);
            this.TitleBarPanel.TabIndex = 4;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Animated = true;
            this.ExitBTN.BorderRadius = 4;
            this.ExitBTN.CheckedState.Parent = this.ExitBTN;
            this.ExitBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ExitBTN.CustomImages.Parent = this.ExitBTN;
            this.Ani.SetDecoration(this.ExitBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBTN.FillColor = System.Drawing.Color.Transparent;
            this.ExitBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.HoverState.Parent = this.ExitBTN;
            this.ExitBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.ExitBTN.Location = new System.Drawing.Point(854, 0);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.ShadowDecoration.Parent = this.ExitBTN;
            this.ExitBTN.Size = new System.Drawing.Size(45, 50);
            this.ExitBTN.TabIndex = 3;
            this.ExitBTN.Text = "X";
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Ani.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Ani.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remebermecheck
            // 
            this.Remebermecheck.Animated = true;
            this.Remebermecheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Remebermecheck.CheckedState.BorderRadius = 2;
            this.Remebermecheck.CheckedState.BorderThickness = 0;
            this.Remebermecheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Ani.SetDecoration(this.Remebermecheck, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Remebermecheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Remebermecheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.Remebermecheck.Location = new System.Drawing.Point(30, 311);
            this.Remebermecheck.Name = "Remebermecheck";
            this.Remebermecheck.Size = new System.Drawing.Size(385, 19);
            this.Remebermecheck.TabIndex = 21;
            this.Remebermecheck.Text = "Remeber Me?";
            this.Remebermecheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Remebermecheck.UncheckedState.BorderRadius = 2;
            this.Remebermecheck.UncheckedState.BorderThickness = 0;
            this.Remebermecheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.password.BorderThickness = 0;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.password, Guna.UI2.AnimatorNS.DecorationType.None);
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.password.HoverState.Parent = this.password;
            this.password.IconLeft = ((System.Drawing.Image)(resources.GetObject("password.IconLeft")));
            this.password.Location = new System.Drawing.Point(30, 260);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password.PlaceholderText = "Password";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(385, 36);
            this.password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.password.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.Ani.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(27, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Login with an existing account";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Animated = true;
            this.LoginBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.LoginBTN.BorderRadius = 2;
            this.LoginBTN.BorderThickness = 2;
            this.LoginBTN.CheckedState.Parent = this.LoginBTN;
            this.LoginBTN.CustomImages.Parent = this.LoginBTN;
            this.Ani.SetDecoration(this.LoginBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LoginBTN.FillColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.HoverState.Parent = this.LoginBTN;
            this.LoginBTN.Location = new System.Drawing.Point(30, 358);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.PressedColor = System.Drawing.Color.White;
            this.LoginBTN.ShadowDecoration.Parent = this.LoginBTN;
            this.LoginBTN.Size = new System.Drawing.Size(385, 37);
            this.LoginBTN.TabIndex = 16;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.Ani.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(26, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "LOGIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.username.BorderThickness = 0;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.username, Guna.UI2.AnimatorNS.DecorationType.None);
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.username.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.username.HoverState.Parent = this.username;
            this.username.IconLeft = ((System.Drawing.Image)(resources.GetObject("username.IconLeft")));
            this.username.Location = new System.Drawing.Point(30, 208);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username.PlaceholderText = "Username";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(385, 36);
            this.username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.username.TabIndex = 10;
            // 
            // DragControl1
            // 
            this.DragControl1.ContainerControl = this;
            this.DragControl1.TargetControl = this.TitleBarPanel;
            // 
            // RegistePanel
            // 
            this.RegistePanel.Controls.Add(this.ShowLoginBTN);
            this.RegistePanel.Controls.Add(this.label9);
            this.RegistePanel.Controls.Add(this.Regtoken);
            this.RegistePanel.Controls.Add(this.Regpass);
            this.RegistePanel.Controls.Add(this.label3);
            this.RegistePanel.Controls.Add(this.RegisterBTN);
            this.RegistePanel.Controls.Add(this.label4);
            this.RegistePanel.Controls.Add(this.Reguser);
            this.Ani.SetDecoration(this.RegistePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegistePanel.Location = new System.Drawing.Point(453, 118);
            this.RegistePanel.Name = "RegistePanel";
            this.RegistePanel.Size = new System.Drawing.Size(404, 398);
            this.RegistePanel.TabIndex = 22;
            this.RegistePanel.Visible = false;
            // 
            // ShowLoginBTN
            // 
            this.ShowLoginBTN.AutoSize = true;
            this.Ani.SetDecoration(this.ShowLoginBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowLoginBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShowLoginBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.ShowLoginBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLoginBTN.Location = new System.Drawing.Point(113, 338);
            this.ShowLoginBTN.Name = "ShowLoginBTN";
            this.ShowLoginBTN.Size = new System.Drawing.Size(66, 15);
            this.ShowLoginBTN.TabIndex = 29;
            this.ShowLoginBTN.Text = "Login here";
            this.ShowLoginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLoginBTN.Click += new System.EventHandler(this.ShowLoginBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.Ani.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(7, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Have an account?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Regtoken
            // 
            this.Regtoken.Animated = true;
            this.Regtoken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Regtoken.BorderThickness = 0;
            this.Regtoken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Regtoken, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Regtoken.DefaultText = "";
            this.Regtoken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regtoken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regtoken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regtoken.DisabledState.Parent = this.Regtoken;
            this.Regtoken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regtoken.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Regtoken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Regtoken.FocusedState.Parent = this.Regtoken;
            this.Regtoken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Regtoken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Regtoken.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Regtoken.HoverState.Parent = this.Regtoken;
            this.Regtoken.IconLeft = ((System.Drawing.Image)(resources.GetObject("Regtoken.IconLeft")));
            this.Regtoken.IconLeftSize = new System.Drawing.Size(23, 23);
            this.Regtoken.Location = new System.Drawing.Point(10, 198);
            this.Regtoken.Name = "Regtoken";
            this.Regtoken.PasswordChar = '*';
            this.Regtoken.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Regtoken.PlaceholderText = "Token";
            this.Regtoken.SelectedText = "";
            this.Regtoken.ShadowDecoration.Parent = this.Regtoken;
            this.Regtoken.Size = new System.Drawing.Size(384, 36);
            this.Regtoken.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Regtoken.TabIndex = 27;
            // 
            // Regpass
            // 
            this.Regpass.Animated = true;
            this.Regpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Regpass.BorderThickness = 0;
            this.Regpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Regpass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Regpass.DefaultText = "";
            this.Regpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regpass.DisabledState.Parent = this.Regpass;
            this.Regpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Regpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Regpass.FocusedState.Parent = this.Regpass;
            this.Regpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Regpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Regpass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Regpass.HoverState.Parent = this.Regpass;
            this.Regpass.IconLeft = ((System.Drawing.Image)(resources.GetObject("Regpass.IconLeft")));
            this.Regpass.Location = new System.Drawing.Point(9, 145);
            this.Regpass.Name = "Regpass";
            this.Regpass.PasswordChar = '*';
            this.Regpass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Regpass.PlaceholderText = "Password";
            this.Regpass.SelectedText = "";
            this.Regpass.ShadowDecoration.Parent = this.Regpass;
            this.Regpass.Size = new System.Drawing.Size(385, 36);
            this.Regpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Regpass.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Ani.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Make a new account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Animated = true;
            this.RegisterBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.RegisterBTN.BorderRadius = 2;
            this.RegisterBTN.BorderThickness = 2;
            this.RegisterBTN.CheckedState.Parent = this.RegisterBTN;
            this.RegisterBTN.CustomImages.Parent = this.RegisterBTN;
            this.Ani.SetDecoration(this.RegisterBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegisterBTN.FillColor = System.Drawing.Color.Transparent;
            this.RegisterBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RegisterBTN.ForeColor = System.Drawing.Color.White;
            this.RegisterBTN.HoverState.Parent = this.RegisterBTN;
            this.RegisterBTN.Location = new System.Drawing.Point(10, 274);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.PressedColor = System.Drawing.Color.White;
            this.RegisterBTN.ShadowDecoration.Parent = this.RegisterBTN;
            this.RegisterBTN.Size = new System.Drawing.Size(384, 37);
            this.RegisterBTN.TabIndex = 24;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Ani.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "REGISTER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reguser
            // 
            this.Reguser.Animated = true;
            this.Reguser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Reguser.BorderThickness = 0;
            this.Reguser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ani.SetDecoration(this.Reguser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Reguser.DefaultText = "";
            this.Reguser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Reguser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Reguser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Reguser.DisabledState.Parent = this.Reguser;
            this.Reguser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Reguser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Reguser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.Reguser.FocusedState.Parent = this.Reguser;
            this.Reguser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Reguser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Reguser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Reguser.HoverState.Parent = this.Reguser;
            this.Reguser.IconLeft = ((System.Drawing.Image)(resources.GetObject("Reguser.IconLeft")));
            this.Reguser.Location = new System.Drawing.Point(9, 93);
            this.Reguser.Name = "Reguser";
            this.Reguser.PasswordChar = '\0';
            this.Reguser.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Reguser.PlaceholderText = "Username";
            this.Reguser.SelectedText = "";
            this.Reguser.ShadowDecoration.Parent = this.Reguser;
            this.Reguser.Size = new System.Drawing.Size(385, 36);
            this.Reguser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Reguser.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.Ani.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(27, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "New user?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowRegBTN
            // 
            this.ShowRegBTN.AutoSize = true;
            this.Ani.SetDecoration(this.ShowRegBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowRegBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShowRegBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.ShowRegBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Location = new System.Drawing.Point(91, 426);
            this.ShowRegBTN.Name = "ShowRegBTN";
            this.ShowRegBTN.Size = new System.Drawing.Size(83, 15);
            this.ShowRegBTN.TabIndex = 24;
            this.ShowRegBTN.Text = "Register here";
            this.ShowRegBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRegBTN.Click += new System.EventHandler(this.ShowRegBTN_Click);
            // 
            // Ani
            // 
            this.Ani.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Ani.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Ani.DefaultAnimation = animation1;
            // 
            // guna2ProgressBar2
            // 
            this.guna2ProgressBar2.BorderRadius = 1;
            this.Ani.SetDecoration(this.guna2ProgressBar2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ProgressBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar2.Location = new System.Drawing.Point(0, 50);
            this.guna2ProgressBar2.Minimum = 60;
            this.guna2ProgressBar2.Name = "guna2ProgressBar2";
            this.guna2ProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.guna2ProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(48)))), ((int)(((byte)(194)))));
            this.guna2ProgressBar2.ShadowDecoration.Parent = this.guna2ProgressBar2;
            this.guna2ProgressBar2.Size = new System.Drawing.Size(899, 3);
            this.guna2ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar2.TabIndex = 26;
            this.guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar2.Value = 100;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(899, 537);
            this.Controls.Add(this.guna2ProgressBar2);
            this.Controls.Add(this.RegistePanel);
            this.Controls.Add(this.ShowRegBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Remebermecheck);
            this.Controls.Add(this.password);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Ani.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.RegistePanel.ResumeLayout(false);
            this.RegistePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel TitleBarPanel;
        private Guna.UI2.WinForms.Guna2Button ExitBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox Remebermecheck;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button LoginBTN;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private System.Windows.Forms.Label ShowRegBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel RegistePanel;
        private Guna.UI2.WinForms.Guna2TextBox Regtoken;
        private Guna.UI2.WinForms.Guna2TextBox Regpass;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button RegisterBTN;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Reguser;
        private System.Windows.Forms.Label ShowLoginBTN;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Transition Ani;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
    }
}