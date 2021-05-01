﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices
{
    public partial class Alert : Form
    {
        public Alert(string title, string value)
        {
            InitializeComponent();
            TitleLabel.Text = title;
            textBox.Text = value;
        }

        public static void Show (string title, string message)
        {
            new Alert(title, message).ShowDialog();
        }
        
        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
