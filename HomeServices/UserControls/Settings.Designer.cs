
namespace HomeServices.UserControls
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DiscordCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AutoLoginCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apptopmost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.apptopmost);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.infolabel);
            this.guna2Panel1.Controls.Add(this.DiscordCheck);
            this.guna2Panel1.Controls.Add(this.AutoLoginCheck);
            this.guna2Panel1.Controls.Add(this.label25);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(36, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(881, 232);
            this.guna2Panel1.TabIndex = 19;
            // 
            // DiscordCheck
            // 
            this.DiscordCheck.Animated = true;
            this.DiscordCheck.AutoSize = true;
            this.DiscordCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiscordCheck.CheckedState.BorderRadius = 2;
            this.DiscordCheck.CheckedState.BorderThickness = 0;
            this.DiscordCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiscordCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DiscordCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.DiscordCheck.Location = new System.Drawing.Point(36, 112);
            this.DiscordCheck.Name = "DiscordCheck";
            this.DiscordCheck.Size = new System.Drawing.Size(127, 19);
            this.DiscordCheck.TabIndex = 19;
            this.DiscordCheck.Text = "Show Discord RPC";
            this.DiscordCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DiscordCheck.UncheckedState.BorderRadius = 2;
            this.DiscordCheck.UncheckedState.BorderThickness = 0;
            this.DiscordCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DiscordCheck.CheckedChanged += new System.EventHandler(this.DiscordCheck_CheckedChanged);
            // 
            // AutoLoginCheck
            // 
            this.AutoLoginCheck.Animated = true;
            this.AutoLoginCheck.AutoSize = true;
            this.AutoLoginCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoLoginCheck.CheckedState.BorderRadius = 2;
            this.AutoLoginCheck.CheckedState.BorderThickness = 0;
            this.AutoLoginCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoLoginCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AutoLoginCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.AutoLoginCheck.Location = new System.Drawing.Point(36, 68);
            this.AutoLoginCheck.Name = "AutoLoginCheck";
            this.AutoLoginCheck.Size = new System.Drawing.Size(143, 19);
            this.AutoLoginCheck.TabIndex = 18;
            this.AutoLoginCheck.Text = "Auto login on startup";
            this.AutoLoginCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoLoginCheck.UncheckedState.BorderRadius = 2;
            this.AutoLoginCheck.UncheckedState.BorderThickness = 0;
            this.AutoLoginCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoLoginCheck.CheckedChanged += new System.EventHandler(this.AutoLoginCheck_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(392, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 17);
            this.label25.TabIndex = 15;
            this.label25.Text = "General Settings";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.guna2Button1.Location = new System.Drawing.Point(841, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(30, 32);
            this.guna2Button1.TabIndex = 1;
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.infolabel.ForeColor = System.Drawing.Color.Tomato;
            this.infolabel.Location = new System.Drawing.Point(33, 134);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(193, 15);
            this.infolabel.TabIndex = 20;
            this.infolabel.Text = "Restart App to apply RPC changes";
            this.infolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infolabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(707, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Made by HoverCore - V1.0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // apptopmost
            // 
            this.apptopmost.Animated = true;
            this.apptopmost.AutoSize = true;
            this.apptopmost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apptopmost.CheckedState.BorderRadius = 2;
            this.apptopmost.CheckedState.BorderThickness = 0;
            this.apptopmost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apptopmost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.apptopmost.ForeColor = System.Drawing.Color.Gainsboro;
            this.apptopmost.Location = new System.Drawing.Point(277, 68);
            this.apptopmost.Name = "apptopmost";
            this.apptopmost.Size = new System.Drawing.Size(139, 19);
            this.apptopmost.TabIndex = 22;
            this.apptopmost.Text = "Application TopMost";
            this.apptopmost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.apptopmost.UncheckedState.BorderRadius = 2;
            this.apptopmost.UncheckedState.BorderThickness = 0;
            this.apptopmost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.apptopmost.CheckedChanged += new System.EventHandler(this.apptopmost_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(968, 482);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox AutoLoginCheck;
        private System.Windows.Forms.Label label25;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CheckBox DiscordCheck;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox apptopmost;
    }
}
