
namespace HomeServices.MainForms
{
    partial class MainForm
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
            Guna.UI2.AnimatorNS.Animation animation7 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.AnimatorNS.Animation animation8 = new Guna.UI2.AnimatorNS.Animation();
            this.ButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SettitsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ExtraToolsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.LogoBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPlansBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowHomeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowTicketBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowDiscordBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowIPToolsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ShowAttackBTN = new Guna.UI2.WinForms.Guna2Button();
            this.TitleBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ShowMenuBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.GunaTIP = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.DotsPanel = new System.Windows.Forms.Panel();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2Button();
            this.OpenDiscordBTN = new Guna.UI2.WinForms.Guna2Button();
            this.MinmizeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Ani = new Guna.UI2.WinForms.Guna2Transition();
            this.Trans = new Guna.UI2.WinForms.Guna2Transition();
            this.SafeCheckPanel = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseCheckBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            this.DotsPanel.SuspendLayout();
            this.SafeCheckPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonPanel.Controls.Add(this.SettitsBTN);
            this.ButtonPanel.Controls.Add(this.ExtraToolsBTN);
            this.ButtonPanel.Controls.Add(this.LogoBTN);
            this.ButtonPanel.Controls.Add(this.ShowPlansBTN);
            this.ButtonPanel.Controls.Add(this.ShowHomeBTN);
            this.ButtonPanel.Controls.Add(this.ShowTicketBTN);
            this.ButtonPanel.Controls.Add(this.ShowDiscordBTN);
            this.ButtonPanel.Controls.Add(this.ShowIPToolsBTN);
            this.ButtonPanel.Controls.Add(this.ShowAttackBTN);
            this.Trans.SetDecoration(this.ButtonPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ButtonPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.ShadowDecoration.Parent = this.ButtonPanel;
            this.ButtonPanel.Size = new System.Drawing.Size(70, 532);
            this.ButtonPanel.TabIndex = 0;
            // 
            // SettitsBTN
            // 
            this.SettitsBTN.BorderRadius = 4;
            this.SettitsBTN.CheckedState.Parent = this.SettitsBTN;
            this.SettitsBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.SettitsBTN.CustomImages.Parent = this.SettitsBTN;
            this.Trans.SetDecoration(this.SettitsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.SettitsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SettitsBTN.FillColor = System.Drawing.Color.Transparent;
            this.SettitsBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SettitsBTN.ForeColor = System.Drawing.Color.White;
            this.SettitsBTN.HoverState.Parent = this.SettitsBTN;
            this.SettitsBTN.Image = ((System.Drawing.Image)(resources.GetObject("SettitsBTN.Image")));
            this.SettitsBTN.ImageSize = new System.Drawing.Size(27, 28);
            this.SettitsBTN.Location = new System.Drawing.Point(12, 414);
            this.SettitsBTN.Name = "SettitsBTN";
            this.SettitsBTN.PressedDepth = 0;
            this.SettitsBTN.ShadowDecoration.Parent = this.SettitsBTN;
            this.SettitsBTN.Size = new System.Drawing.Size(47, 38);
            this.SettitsBTN.TabIndex = 15;
            this.GunaTIP.SetToolTip(this.SettitsBTN, "Settings");
            this.SettitsBTN.Click += new System.EventHandler(this.SettitsBTN_Click);
            // 
            // ExtraToolsBTN
            // 
            this.ExtraToolsBTN.BorderRadius = 4;
            this.ExtraToolsBTN.CheckedState.Parent = this.ExtraToolsBTN;
            this.ExtraToolsBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ExtraToolsBTN.CustomImages.Parent = this.ExtraToolsBTN;
            this.Trans.SetDecoration(this.ExtraToolsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ExtraToolsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ExtraToolsBTN.FillColor = System.Drawing.Color.Transparent;
            this.ExtraToolsBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ExtraToolsBTN.ForeColor = System.Drawing.Color.White;
            this.ExtraToolsBTN.HoverState.Parent = this.ExtraToolsBTN;
            this.ExtraToolsBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExtraToolsBTN.Image")));
            this.ExtraToolsBTN.ImageSize = new System.Drawing.Size(29, 29);
            this.ExtraToolsBTN.Location = new System.Drawing.Point(12, 222);
            this.ExtraToolsBTN.Name = "ExtraToolsBTN";
            this.ExtraToolsBTN.PressedDepth = 0;
            this.ExtraToolsBTN.ShadowDecoration.Parent = this.ExtraToolsBTN;
            this.ExtraToolsBTN.Size = new System.Drawing.Size(47, 38);
            this.ExtraToolsBTN.TabIndex = 14;
            this.GunaTIP.SetToolTip(this.ExtraToolsBTN, "Extra Tools");
            this.ExtraToolsBTN.Click += new System.EventHandler(this.ExtraToolsBTN_Click);
            // 
            // LogoBTN
            // 
            this.LogoBTN.CheckedState.Parent = this.LogoBTN;
            this.LogoBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.LogoBTN.CustomImages.Parent = this.LogoBTN;
            this.Trans.SetDecoration(this.LogoBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.LogoBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBTN.FillColor = System.Drawing.Color.Transparent;
            this.LogoBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LogoBTN.ForeColor = System.Drawing.Color.White;
            this.LogoBTN.HoverState.Parent = this.LogoBTN;
            this.LogoBTN.Image = ((System.Drawing.Image)(resources.GetObject("LogoBTN.Image")));
            this.LogoBTN.ImageSize = new System.Drawing.Size(50, 40);
            this.LogoBTN.Location = new System.Drawing.Point(0, 0);
            this.LogoBTN.Name = "LogoBTN";
            this.LogoBTN.PressedDepth = 0;
            this.LogoBTN.ShadowDecoration.Parent = this.LogoBTN;
            this.LogoBTN.Size = new System.Drawing.Size(70, 50);
            this.LogoBTN.TabIndex = 13;
            this.LogoBTN.Click += new System.EventHandler(this.LogoBTN_Click);
            // 
            // ShowPlansBTN
            // 
            this.ShowPlansBTN.BorderRadius = 4;
            this.ShowPlansBTN.CheckedState.Parent = this.ShowPlansBTN;
            this.ShowPlansBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowPlansBTN.CustomImages.Parent = this.ShowPlansBTN;
            this.Trans.SetDecoration(this.ShowPlansBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowPlansBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowPlansBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowPlansBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowPlansBTN.ForeColor = System.Drawing.Color.White;
            this.ShowPlansBTN.HoverState.Parent = this.ShowPlansBTN;
            this.ShowPlansBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowPlansBTN.Image")));
            this.ShowPlansBTN.ImageSize = new System.Drawing.Size(27, 28);
            this.ShowPlansBTN.Location = new System.Drawing.Point(12, 366);
            this.ShowPlansBTN.Name = "ShowPlansBTN";
            this.ShowPlansBTN.PressedDepth = 0;
            this.ShowPlansBTN.ShadowDecoration.Parent = this.ShowPlansBTN;
            this.ShowPlansBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowPlansBTN.TabIndex = 12;
            this.GunaTIP.SetToolTip(this.ShowPlansBTN, "Plan Hub");
            this.ShowPlansBTN.Click += new System.EventHandler(this.ShowPlansBTN_Click);
            // 
            // ShowHomeBTN
            // 
            this.ShowHomeBTN.BorderRadius = 4;
            this.ShowHomeBTN.CheckedState.Parent = this.ShowHomeBTN;
            this.ShowHomeBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowHomeBTN.CustomImages.Parent = this.ShowHomeBTN;
            this.Trans.SetDecoration(this.ShowHomeBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowHomeBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowHomeBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.ShowHomeBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowHomeBTN.ForeColor = System.Drawing.Color.White;
            this.ShowHomeBTN.HoverState.Parent = this.ShowHomeBTN;
            this.ShowHomeBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowHomeBTN.Image")));
            this.ShowHomeBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.ShowHomeBTN.Location = new System.Drawing.Point(12, 78);
            this.ShowHomeBTN.Name = "ShowHomeBTN";
            this.ShowHomeBTN.PressedDepth = 0;
            this.ShowHomeBTN.ShadowDecoration.Parent = this.ShowHomeBTN;
            this.ShowHomeBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowHomeBTN.TabIndex = 2;
            this.GunaTIP.SetToolTip(this.ShowHomeBTN, "Home Page");
            this.ShowHomeBTN.Click += new System.EventHandler(this.ShowHomeBTN_Click);
            // 
            // ShowTicketBTN
            // 
            this.ShowTicketBTN.BorderRadius = 4;
            this.ShowTicketBTN.CheckedState.Parent = this.ShowTicketBTN;
            this.ShowTicketBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowTicketBTN.CustomImages.Parent = this.ShowTicketBTN;
            this.Trans.SetDecoration(this.ShowTicketBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowTicketBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowTicketBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowTicketBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowTicketBTN.ForeColor = System.Drawing.Color.White;
            this.ShowTicketBTN.HoverState.Parent = this.ShowTicketBTN;
            this.ShowTicketBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowTicketBTN.Image")));
            this.ShowTicketBTN.ImageSize = new System.Drawing.Size(27, 28);
            this.ShowTicketBTN.Location = new System.Drawing.Point(12, 318);
            this.ShowTicketBTN.Name = "ShowTicketBTN";
            this.ShowTicketBTN.PressedDepth = 0;
            this.ShowTicketBTN.ShadowDecoration.Parent = this.ShowTicketBTN;
            this.ShowTicketBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowTicketBTN.TabIndex = 10;
            this.GunaTIP.SetToolTip(this.ShowTicketBTN, "Ticket Hub");
            this.ShowTicketBTN.Click += new System.EventHandler(this.ShowTicketBTN_Click);
            // 
            // ShowDiscordBTN
            // 
            this.ShowDiscordBTN.BorderRadius = 4;
            this.ShowDiscordBTN.CheckedState.Parent = this.ShowDiscordBTN;
            this.ShowDiscordBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowDiscordBTN.CustomImages.Parent = this.ShowDiscordBTN;
            this.Trans.SetDecoration(this.ShowDiscordBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowDiscordBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowDiscordBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowDiscordBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowDiscordBTN.ForeColor = System.Drawing.Color.White;
            this.ShowDiscordBTN.HoverState.Parent = this.ShowDiscordBTN;
            this.ShowDiscordBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowDiscordBTN.Image")));
            this.ShowDiscordBTN.ImageSize = new System.Drawing.Size(27, 28);
            this.ShowDiscordBTN.Location = new System.Drawing.Point(12, 270);
            this.ShowDiscordBTN.Name = "ShowDiscordBTN";
            this.ShowDiscordBTN.PressedDepth = 0;
            this.ShowDiscordBTN.ShadowDecoration.Parent = this.ShowDiscordBTN;
            this.ShowDiscordBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowDiscordBTN.TabIndex = 9;
            this.GunaTIP.SetToolTip(this.ShowDiscordBTN, "Discord Tools");
            this.ShowDiscordBTN.Click += new System.EventHandler(this.ShowDiscordBTN_Click);
            // 
            // ShowIPToolsBTN
            // 
            this.ShowIPToolsBTN.BorderRadius = 4;
            this.ShowIPToolsBTN.CheckedState.Parent = this.ShowIPToolsBTN;
            this.ShowIPToolsBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowIPToolsBTN.CustomImages.Parent = this.ShowIPToolsBTN;
            this.Trans.SetDecoration(this.ShowIPToolsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowIPToolsBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowIPToolsBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowIPToolsBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowIPToolsBTN.ForeColor = System.Drawing.Color.White;
            this.ShowIPToolsBTN.HoverState.Parent = this.ShowIPToolsBTN;
            this.ShowIPToolsBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowIPToolsBTN.Image")));
            this.ShowIPToolsBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.ShowIPToolsBTN.Location = new System.Drawing.Point(12, 174);
            this.ShowIPToolsBTN.Name = "ShowIPToolsBTN";
            this.ShowIPToolsBTN.PressedDepth = 0;
            this.ShowIPToolsBTN.ShadowDecoration.Parent = this.ShowIPToolsBTN;
            this.ShowIPToolsBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowIPToolsBTN.TabIndex = 5;
            this.GunaTIP.SetToolTip(this.ShowIPToolsBTN, "IP Toolbox");
            this.ShowIPToolsBTN.Click += new System.EventHandler(this.ShowIPToolsBTN_Click);
            // 
            // ShowAttackBTN
            // 
            this.ShowAttackBTN.BorderRadius = 4;
            this.ShowAttackBTN.CheckedState.Parent = this.ShowAttackBTN;
            this.ShowAttackBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowAttackBTN.CustomImages.Parent = this.ShowAttackBTN;
            this.Trans.SetDecoration(this.ShowAttackBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowAttackBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowAttackBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowAttackBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowAttackBTN.ForeColor = System.Drawing.Color.White;
            this.ShowAttackBTN.HoverState.Parent = this.ShowAttackBTN;
            this.ShowAttackBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowAttackBTN.Image")));
            this.ShowAttackBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.ShowAttackBTN.Location = new System.Drawing.Point(12, 126);
            this.ShowAttackBTN.Name = "ShowAttackBTN";
            this.ShowAttackBTN.PressedDepth = 0;
            this.ShowAttackBTN.ShadowDecoration.Parent = this.ShowAttackBTN;
            this.ShowAttackBTN.Size = new System.Drawing.Size(47, 38);
            this.ShowAttackBTN.TabIndex = 4;
            this.GunaTIP.SetToolTip(this.ShowAttackBTN, "Attack Hub");
            this.ShowAttackBTN.Click += new System.EventHandler(this.ShowAttackBTN_Click);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TitleBarPanel.Controls.Add(this.StateLabel);
            this.TitleBarPanel.Controls.Add(this.ShowMenuBTN);
            this.TitleBarPanel.Controls.Add(this.label4);
            this.TitleBarPanel.Controls.Add(this.label2);
            this.TitleBarPanel.Controls.Add(this.label1);
            this.Trans.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.TitleBarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(70, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.ShadowDecoration.Parent = this.TitleBarPanel;
            this.TitleBarPanel.Size = new System.Drawing.Size(968, 50);
            this.TitleBarPanel.TabIndex = 1;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // StateLabel
            // 
            this.Ani.SetDecoration(this.StateLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.StateLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.StateLabel.Location = new System.Drawing.Point(148, 14);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(148, 25);
            this.StateLabel.TabIndex = 5;
            this.StateLabel.Text = "Home Page";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowMenuBTN
            // 
            this.ShowMenuBTN.Animated = true;
            this.ShowMenuBTN.BorderRadius = 4;
            this.ShowMenuBTN.CheckedState.Parent = this.ShowMenuBTN;
            this.ShowMenuBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ShowMenuBTN.CustomImages.Parent = this.ShowMenuBTN;
            this.Trans.SetDecoration(this.ShowMenuBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.ShowMenuBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShowMenuBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowMenuBTN.FillColor = System.Drawing.Color.Transparent;
            this.ShowMenuBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowMenuBTN.ForeColor = System.Drawing.Color.White;
            this.ShowMenuBTN.HoverState.Parent = this.ShowMenuBTN;
            this.ShowMenuBTN.Image = ((System.Drawing.Image)(resources.GetObject("ShowMenuBTN.Image")));
            this.ShowMenuBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.ShowMenuBTN.Location = new System.Drawing.Point(923, 0);
            this.ShowMenuBTN.Name = "ShowMenuBTN";
            this.ShowMenuBTN.ShadowDecoration.Parent = this.ShowMenuBTN;
            this.ShowMenuBTN.Size = new System.Drawing.Size(45, 50);
            this.ShowMenuBTN.TabIndex = 3;
            this.ShowMenuBTN.Click += new System.EventHandler(this.ShowMenuBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Ani.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(139, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "\\";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Ani.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(65, 12);
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
            this.Trans.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl1
            // 
            this.DragControl1.ContainerControl = this;
            this.DragControl1.TargetControl = this.TitleBarPanel;
            // 
            // MainPanel
            // 
            this.Trans.SetDecoration(this.MainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.MainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainPanel.Location = new System.Drawing.Point(70, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(968, 482);
            this.MainPanel.TabIndex = 4;
            // 
            // GunaTIP
            // 
            this.GunaTIP.AllowLinksHandling = true;
            this.GunaTIP.AutomaticDelay = 300;
            this.GunaTIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaTIP.ForeColor = System.Drawing.Color.Black;
            this.GunaTIP.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // DotsPanel
            // 
            this.DotsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DotsPanel.Controls.Add(this.CloseBTN);
            this.DotsPanel.Controls.Add(this.OpenDiscordBTN);
            this.DotsPanel.Controls.Add(this.MinmizeBTN);
            this.Trans.SetDecoration(this.DotsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.DotsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DotsPanel.Location = new System.Drawing.Point(921, 50);
            this.DotsPanel.Name = "DotsPanel";
            this.DotsPanel.Size = new System.Drawing.Size(117, 101);
            this.DotsPanel.TabIndex = 0;
            this.DotsPanel.Visible = false;
            // 
            // CloseBTN
            // 
            this.CloseBTN.BorderRadius = 4;
            this.CloseBTN.CheckedState.Parent = this.CloseBTN;
            this.CloseBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.CloseBTN.CustomImages.Parent = this.CloseBTN;
            this.Trans.SetDecoration(this.CloseBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.CloseBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseBTN.FillColor = System.Drawing.Color.Transparent;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CloseBTN.ForeColor = System.Drawing.Color.Red;
            this.CloseBTN.HoverState.Parent = this.CloseBTN;
            this.CloseBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.CloseBTN.Location = new System.Drawing.Point(0, 66);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.PressedDepth = 0;
            this.CloseBTN.ShadowDecoration.Parent = this.CloseBTN;
            this.CloseBTN.Size = new System.Drawing.Size(117, 33);
            this.CloseBTN.TabIndex = 8;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // OpenDiscordBTN
            // 
            this.OpenDiscordBTN.BorderRadius = 4;
            this.OpenDiscordBTN.CheckedState.Parent = this.OpenDiscordBTN;
            this.OpenDiscordBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.OpenDiscordBTN.CustomImages.Parent = this.OpenDiscordBTN;
            this.Trans.SetDecoration(this.OpenDiscordBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.OpenDiscordBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OpenDiscordBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenDiscordBTN.FillColor = System.Drawing.Color.Transparent;
            this.OpenDiscordBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.OpenDiscordBTN.ForeColor = System.Drawing.Color.White;
            this.OpenDiscordBTN.HoverState.Parent = this.OpenDiscordBTN;
            this.OpenDiscordBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.OpenDiscordBTN.Location = new System.Drawing.Point(0, 33);
            this.OpenDiscordBTN.Name = "OpenDiscordBTN";
            this.OpenDiscordBTN.PressedDepth = 0;
            this.OpenDiscordBTN.ShadowDecoration.Parent = this.OpenDiscordBTN;
            this.OpenDiscordBTN.Size = new System.Drawing.Size(117, 33);
            this.OpenDiscordBTN.TabIndex = 6;
            this.OpenDiscordBTN.Text = "Discord";
            this.OpenDiscordBTN.Click += new System.EventHandler(this.OpenDiscordBTN_Click);
            // 
            // MinmizeBTN
            // 
            this.MinmizeBTN.BorderRadius = 4;
            this.MinmizeBTN.CheckedState.Parent = this.MinmizeBTN;
            this.MinmizeBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.MinmizeBTN.CustomImages.Parent = this.MinmizeBTN;
            this.Trans.SetDecoration(this.MinmizeBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.MinmizeBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MinmizeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinmizeBTN.FillColor = System.Drawing.Color.Transparent;
            this.MinmizeBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MinmizeBTN.ForeColor = System.Drawing.Color.White;
            this.MinmizeBTN.HoverState.Parent = this.MinmizeBTN;
            this.MinmizeBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.MinmizeBTN.Location = new System.Drawing.Point(0, 0);
            this.MinmizeBTN.Name = "MinmizeBTN";
            this.MinmizeBTN.PressedDepth = 0;
            this.MinmizeBTN.ShadowDecoration.Parent = this.MinmizeBTN;
            this.MinmizeBTN.Size = new System.Drawing.Size(117, 33);
            this.MinmizeBTN.TabIndex = 5;
            this.MinmizeBTN.Text = "Minimize";
            this.MinmizeBTN.Click += new System.EventHandler(this.MinmizeBTN_Click);
            // 
            // Ani
            // 
            this.Ani.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.Ani.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.Ani.DefaultAnimation = animation7;
            // 
            // Trans
            // 
            this.Trans.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Trans.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.Trans.DefaultAnimation = animation8;
            // 
            // SafeCheckPanel
            // 
            this.SafeCheckPanel.Controls.Add(this.guna2Panel2);
            this.SafeCheckPanel.Controls.Add(this.label5);
            this.SafeCheckPanel.Controls.Add(this.label19);
            this.SafeCheckPanel.Controls.Add(this.guna2Separator1);
            this.SafeCheckPanel.Controls.Add(this.label6);
            this.Trans.SetDecoration(this.SafeCheckPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.SafeCheckPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SafeCheckPanel.Location = new System.Drawing.Point(70, 50);
            this.SafeCheckPanel.Name = "SafeCheckPanel";
            this.SafeCheckPanel.Size = new System.Drawing.Size(968, 482);
            this.SafeCheckPanel.TabIndex = 5;
            this.SafeCheckPanel.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.CloseCheckBTN);
            this.guna2Panel2.Controls.Add(this.OutputBox);
            this.guna2Panel2.Controls.Add(this.label18);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Trans.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(40, 142);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(895, 313);
            this.guna2Panel2.TabIndex = 29;
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Trans.SetDecoration(this.OutputBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.OutputBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OutputBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.OutputBox.ForeColor = System.Drawing.Color.Gray;
            this.OutputBox.Location = new System.Drawing.Point(27, 44);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(844, 230);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "N/a";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.Ani.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(399, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 19);
            this.label18.TabIndex = 1;
            this.label18.Text = "Safe Check Status";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.Ani.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(359, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "We are checking if something is out of ordinary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.Ani.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.LightGray;
            this.label19.Location = new System.Drawing.Point(437, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "Why am I seeing this?";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Trans.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(41, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(895, 10);
            this.guna2Separator1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.Ani.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Trans.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(418, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Application Safe Check";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckTimer
            // 
            this.CheckTimer.Interval = 3600000;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // CloseCheckBTN
            // 
            this.CloseCheckBTN.BorderRadius = 4;
            this.CloseCheckBTN.CheckedState.Parent = this.CloseCheckBTN;
            this.CloseCheckBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.CloseCheckBTN.CustomImages.Parent = this.CloseCheckBTN;
            this.Trans.SetDecoration(this.CloseCheckBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this.CloseCheckBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseCheckBTN.Enabled = false;
            this.CloseCheckBTN.FillColor = System.Drawing.Color.Transparent;
            this.CloseCheckBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CloseCheckBTN.ForeColor = System.Drawing.Color.Silver;
            this.CloseCheckBTN.HoverState.Parent = this.CloseCheckBTN;
            this.CloseCheckBTN.ImageSize = new System.Drawing.Size(27, 27);
            this.CloseCheckBTN.Location = new System.Drawing.Point(754, 272);
            this.CloseCheckBTN.Name = "CloseCheckBTN";
            this.CloseCheckBTN.PressedDepth = 0;
            this.CloseCheckBTN.ShadowDecoration.Parent = this.CloseCheckBTN;
            this.CloseCheckBTN.Size = new System.Drawing.Size(117, 28);
            this.CloseCheckBTN.TabIndex = 9;
            this.CloseCheckBTN.Text = "Close This";
            this.CloseCheckBTN.Click += new System.EventHandler(this.CloseCheckBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1038, 532);
            this.Controls.Add(this.DotsPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SafeCheckPanel);
            this.Controls.Add(this.MainPanel);
            this.Trans.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Ani.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Services";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.DotsPanel.ResumeLayout(false);
            this.SafeCheckPanel.ResumeLayout(false);
            this.SafeCheckPanel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ButtonPanel;
        private Guna.UI2.WinForms.Guna2Panel TitleBarPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ShowHomeBTN;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2Button ShowAttackBTN;
        private Guna.UI2.WinForms.Guna2Button ShowIPToolsBTN;
        private Guna.UI2.WinForms.Guna2Button ShowDiscordBTN;
        private Guna.UI2.WinForms.Guna2Button ShowPlansBTN;
        private Guna.UI2.WinForms.Guna2Button ShowTicketBTN;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button ShowMenuBTN;
        private Guna.UI2.WinForms.Guna2HtmlToolTip GunaTIP;
        private System.Windows.Forms.Label StateLabel;
        private Guna.UI2.WinForms.Guna2Button LogoBTN;
        private Guna.UI2.WinForms.Guna2Button ExtraToolsBTN;
        private Guna.UI2.WinForms.Guna2Button SettitsBTN;
        private System.Windows.Forms.Panel DotsPanel;
        private Guna.UI2.WinForms.Guna2Button CloseBTN;
        private Guna.UI2.WinForms.Guna2Button OpenDiscordBTN;
        private Guna.UI2.WinForms.Guna2Button MinmizeBTN;
        private Guna.UI2.WinForms.Guna2Transition Ani;
        private Guna.UI2.WinForms.Guna2Transition Trans;
        private System.Windows.Forms.Panel SafeCheckPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer CheckTimer;
        private Guna.UI2.WinForms.Guna2Button CloseCheckBTN;
    }
}