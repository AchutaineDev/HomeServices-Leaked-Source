
namespace HomeServices.UserControls
{
    partial class TicketHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketHub));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketBox = new System.Windows.Forms.RichTextBox();
            this.message = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendNewTicketBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label25 = new System.Windows.Forms.Label();
            this.title = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(35, 54);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(895, 10);
            this.guna2Separator1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Support Room - Ticket Hub";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.TicketBox);
            this.guna2Panel1.Controls.Add(this.message);
            this.guna2Panel1.Controls.Add(this.SendNewTicketBTN);
            this.guna2Panel1.Controls.Add(this.label25);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(35, 88);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(895, 358);
            this.guna2Panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Last Ticket Messages";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketBox
            // 
            this.TicketBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TicketBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TicketBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TicketBox.ForeColor = System.Drawing.Color.Gray;
            this.TicketBox.Location = new System.Drawing.Point(500, 59);
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.ReadOnly = true;
            this.TicketBox.Size = new System.Drawing.Size(371, 276);
            this.TicketBox.TabIndex = 30;
            this.TicketBox.Text = "N/a";
            // 
            // message
            // 
            this.message.Animated = true;
            this.message.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.message.BorderThickness = 0;
            this.message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message.DefaultText = "";
            this.message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.DisabledState.Parent = this.message;
            this.message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.message.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.message.FocusedState.Parent = this.message;
            this.message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.message.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.message.HoverState.Parent = this.message;
            this.message.Location = new System.Drawing.Point(29, 103);
            this.message.Name = "message";
            this.message.PasswordChar = '\0';
            this.message.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.message.PlaceholderText = "Message";
            this.message.SelectedText = "";
            this.message.ShadowDecoration.Parent = this.message;
            this.message.Size = new System.Drawing.Size(407, 36);
            this.message.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.message.TabIndex = 17;
            // 
            // SendNewTicketBTN
            // 
            this.SendNewTicketBTN.Animated = true;
            this.SendNewTicketBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.SendNewTicketBTN.BorderRadius = 3;
            this.SendNewTicketBTN.BorderThickness = 2;
            this.SendNewTicketBTN.CheckedState.Parent = this.SendNewTicketBTN;
            this.SendNewTicketBTN.CustomImages.Parent = this.SendNewTicketBTN;
            this.SendNewTicketBTN.FillColor = System.Drawing.Color.Transparent;
            this.SendNewTicketBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendNewTicketBTN.ForeColor = System.Drawing.Color.White;
            this.SendNewTicketBTN.HoverState.Parent = this.SendNewTicketBTN;
            this.SendNewTicketBTN.Location = new System.Drawing.Point(29, 157);
            this.SendNewTicketBTN.Name = "SendNewTicketBTN";
            this.SendNewTicketBTN.PressedColor = System.Drawing.Color.White;
            this.SendNewTicketBTN.ShadowDecoration.Parent = this.SendNewTicketBTN;
            this.SendNewTicketBTN.Size = new System.Drawing.Size(210, 35);
            this.SendNewTicketBTN.TabIndex = 16;
            this.SendNewTicketBTN.Text = "Send";
            this.SendNewTicketBTN.Click += new System.EventHandler(this.SendNewTicketBTN_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(26, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 15);
            this.label25.TabIndex = 15;
            this.label25.Text = "Ticket Manager";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Animated = true;
            this.title.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.title.BorderThickness = 0;
            this.title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.title.DefaultText = "";
            this.title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.title.DisabledState.Parent = this.title;
            this.title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.title.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(20)))), ((int)(((byte)(166)))));
            this.title.FocusedState.Parent = this.title;
            this.title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.title.HoverState.Parent = this.title;
            this.title.Location = new System.Drawing.Point(29, 59);
            this.title.Name = "title";
            this.title.PasswordChar = '\0';
            this.title.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.title.PlaceholderText = "Title";
            this.title.SelectedText = "";
            this.title.ShadowDecoration.Parent = this.title;
            this.title.Size = new System.Drawing.Size(407, 36);
            this.title.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.title.TabIndex = 10;
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
            // TicketHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TicketHub";
            this.Size = new System.Drawing.Size(968, 482);
            this.Load += new System.EventHandler(this.TicketHub_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TicketBox;
        private Guna.UI2.WinForms.Guna2TextBox message;
        private Guna.UI2.WinForms.Guna2Button SendNewTicketBTN;
        private System.Windows.Forms.Label label25;
        private Guna.UI2.WinForms.Guna2TextBox title;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
