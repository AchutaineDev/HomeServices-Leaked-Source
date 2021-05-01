
namespace HomeServices.UserControls
{
    partial class DiscordTools
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordTools));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SendBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label25 = new System.Windows.Forms.Label();
            this.url = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.msg = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogsBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpamBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SpamTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearAttackLogs = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(25, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(895, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(422, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Discord Tools";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.ClearAttackLogs);
            this.guna2Panel1.Controls.Add(this.SpamBTN);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.LogsBox);
            this.guna2Panel1.Controls.Add(this.msg);
            this.guna2Panel1.Controls.Add(this.name);
            this.guna2Panel1.Controls.Add(this.SendBTN);
            this.guna2Panel1.Controls.Add(this.label25);
            this.guna2Panel1.Controls.Add(this.url);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(25, 85);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(895, 358);
            this.guna2Panel1.TabIndex = 18;
            // 
            // SendBTN
            // 
            this.SendBTN.Animated = true;
            this.SendBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.SendBTN.BorderRadius = 3;
            this.SendBTN.BorderThickness = 2;
            this.SendBTN.CheckedState.Parent = this.SendBTN;
            this.SendBTN.CustomImages.Parent = this.SendBTN;
            this.SendBTN.FillColor = System.Drawing.Color.Transparent;
            this.SendBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendBTN.ForeColor = System.Drawing.Color.White;
            this.SendBTN.HoverState.Parent = this.SendBTN;
            this.SendBTN.Location = new System.Drawing.Point(24, 208);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.PressedColor = System.Drawing.Color.White;
            this.SendBTN.ShadowDecoration.Parent = this.SendBTN;
            this.SendBTN.Size = new System.Drawing.Size(210, 35);
            this.SendBTN.TabIndex = 16;
            this.SendBTN.Text = "Send";
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(26, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(187, 15);
            this.label25.TabIndex = 15;
            this.label25.Text = "Webhook Spammer and Deleter";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // url
            // 
            this.url.Animated = true;
            this.url.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.url.BorderThickness = 0;
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.DefaultText = "";
            this.url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.DisabledState.Parent = this.url;
            this.url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.url.FocusedState.Parent = this.url;
            this.url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.url.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.url.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.url.HoverState.Parent = this.url;
            this.url.Location = new System.Drawing.Point(24, 74);
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.url.PlaceholderText = "Webhook URL";
            this.url.SelectedText = "";
            this.url.ShadowDecoration.Parent = this.url;
            this.url.Size = new System.Drawing.Size(407, 36);
            this.url.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.url.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(27, 27);
            this.guna2Button1.Location = new System.Drawing.Point(856, 11);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(25, 25);
            this.guna2Button1.TabIndex = 1;
            // 
            // name
            // 
            this.name.Animated = true;
            this.name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.name.BorderThickness = 0;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(24, 116);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.name.PlaceholderText = "Webhook Name";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(407, 36);
            this.name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name.TabIndex = 17;
            // 
            // msg
            // 
            this.msg.Animated = true;
            this.msg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.msg.BorderThickness = 0;
            this.msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msg.DefaultText = "";
            this.msg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.msg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.msg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg.DisabledState.Parent = this.msg;
            this.msg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.msg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.msg.FocusedState.Parent = this.msg;
            this.msg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msg.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.msg.HoverState.Parent = this.msg;
            this.msg.Location = new System.Drawing.Point(24, 158);
            this.msg.Name = "msg";
            this.msg.PasswordChar = '\0';
            this.msg.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.msg.PlaceholderText = "Webhook Message";
            this.msg.SelectedText = "";
            this.msg.ShadowDecoration.Parent = this.msg;
            this.msg.Size = new System.Drawing.Size(407, 36);
            this.msg.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.msg.TabIndex = 18;
            // 
            // LogsBox
            // 
            this.LogsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LogsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LogsBox.ForeColor = System.Drawing.Color.Gray;
            this.LogsBox.Location = new System.Drawing.Point(500, 59);
            this.LogsBox.Name = "LogsBox";
            this.LogsBox.ReadOnly = true;
            this.LogsBox.Size = new System.Drawing.Size(371, 276);
            this.LogsBox.TabIndex = 30;
            this.LogsBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "All Logs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpamBTN
            // 
            this.SpamBTN.Animated = true;
            this.SpamBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.SpamBTN.BorderRadius = 3;
            this.SpamBTN.BorderThickness = 2;
            this.SpamBTN.CheckedState.Parent = this.SpamBTN;
            this.SpamBTN.CustomImages.Parent = this.SpamBTN;
            this.SpamBTN.FillColor = System.Drawing.Color.Transparent;
            this.SpamBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SpamBTN.ForeColor = System.Drawing.Color.White;
            this.SpamBTN.HoverState.Parent = this.SpamBTN;
            this.SpamBTN.Location = new System.Drawing.Point(24, 267);
            this.SpamBTN.Name = "SpamBTN";
            this.SpamBTN.PressedColor = System.Drawing.Color.White;
            this.SpamBTN.ShadowDecoration.Parent = this.SpamBTN;
            this.SpamBTN.Size = new System.Drawing.Size(407, 35);
            this.SpamBTN.TabIndex = 33;
            this.SpamBTN.Text = "Start Spam";
            this.SpamBTN.Click += new System.EventHandler(this.SpamBTN_Click);
            // 
            // SpamTimer
            // 
            this.SpamTimer.Interval = 1000;
            this.SpamTimer.Tick += new System.EventHandler(this.SpamTimer_Tick);
            // 
            // ClearAttackLogs
            // 
            this.ClearAttackLogs.Animated = true;
            this.ClearAttackLogs.BorderColor = System.Drawing.Color.DarkRed;
            this.ClearAttackLogs.BorderRadius = 3;
            this.ClearAttackLogs.BorderThickness = 2;
            this.ClearAttackLogs.CheckedState.Parent = this.ClearAttackLogs;
            this.ClearAttackLogs.CustomImages.Parent = this.ClearAttackLogs;
            this.ClearAttackLogs.FillColor = System.Drawing.Color.Transparent;
            this.ClearAttackLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ClearAttackLogs.ForeColor = System.Drawing.Color.White;
            this.ClearAttackLogs.HoverState.Parent = this.ClearAttackLogs;
            this.ClearAttackLogs.Image = ((System.Drawing.Image)(resources.GetObject("ClearAttackLogs.Image")));
            this.ClearAttackLogs.ImageSize = new System.Drawing.Size(19, 19);
            this.ClearAttackLogs.Location = new System.Drawing.Point(243, 208);
            this.ClearAttackLogs.Name = "ClearAttackLogs";
            this.ClearAttackLogs.PressedColor = System.Drawing.Color.White;
            this.ClearAttackLogs.ShadowDecoration.Parent = this.ClearAttackLogs;
            this.ClearAttackLogs.Size = new System.Drawing.Size(38, 35);
            this.ClearAttackLogs.TabIndex = 34;
            this.ClearAttackLogs.Click += new System.EventHandler(this.ClearAttackLogs_Click);
            // 
            // DiscordTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DiscordTools";
            this.Size = new System.Drawing.Size(968, 482);
            this.Load += new System.EventHandler(this.DiscordTools_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button SendBTN;
        private System.Windows.Forms.Label label25;
        private Guna.UI2.WinForms.Guna2TextBox url;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox msg;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2Button SpamBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox LogsBox;
        private System.Windows.Forms.Timer SpamTimer;
        private Guna.UI2.WinForms.Guna2Button ClearAttackLogs;
    }
}
