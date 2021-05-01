
namespace HomeServices
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.TitleBanner = new Guna.UI2.WinForms.Guna2Panel();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Rounded = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TitleBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBanner
            // 
            this.TitleBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(18)))), ((int)(((byte)(122)))));
            this.TitleBanner.Controls.Add(this.CloseBTN);
            this.TitleBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBanner.Location = new System.Drawing.Point(0, 0);
            this.TitleBanner.Name = "TitleBanner";
            this.TitleBanner.ShadowDecoration.Parent = this.TitleBanner;
            this.TitleBanner.Size = new System.Drawing.Size(596, 35);
            this.TitleBanner.TabIndex = 0;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Animated = true;
            this.CloseBTN.BorderColor = System.Drawing.Color.Transparent;
            this.CloseBTN.CheckedState.Parent = this.CloseBTN;
            this.CloseBTN.CustomImages.Parent = this.CloseBTN;
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FillColor = System.Drawing.Color.Transparent;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.HoverState.Parent = this.CloseBTN;
            this.CloseBTN.Location = new System.Drawing.Point(555, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.PressedColor = System.Drawing.Color.White;
            this.CloseBTN.ShadowDecoration.Parent = this.CloseBTN;
            this.CloseBTN.Size = new System.Drawing.Size(41, 35);
            this.CloseBTN.TabIndex = 10;
            this.CloseBTN.Text = "X";
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.Location = new System.Drawing.Point(15, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(563, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Silver;
            this.textBox.Location = new System.Drawing.Point(19, 76);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(563, 194);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "Messsage";
            // 
            // DragControl1
            // 
            this.DragControl1.ContainerControl = this;
            this.DragControl1.TargetControl = this.TitleBanner;
            // 
            // Rounded
            // 
            this.Rounded.TargetControl = this;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(596, 286);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alert_Load);
            this.TitleBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TitleBanner;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox textBox;
        private Guna.UI2.WinForms.Guna2Button CloseBTN;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse Rounded;
    }
}