using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices.UserControls
{
    public partial class ExtraTools : UserControl
    {
        public ExtraTools()
        {
            InitializeComponent();
        }

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void ExtraTools_Load(object sender, EventArgs e)
        {

        }

        private void copyBTN_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(output.Text); } catch { }
        }

        private void TrackBTN_Scroll(object sender, ScrollEventArgs e)
        {
            LeghtLBL.Text = $"Length: {TrackBTN.Value}";
            try
            {
                output.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, TrackBTN.Value);
            }
            catch (Exception ex)
            {
                output.Text = "Error: " + ex.Message;
            }
        }

        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, TrackBTN.Value);
            }
            catch (Exception ex)
            {
                output.Text = "Error: " + ex.Message;
            }
        }

        // spam code

        private void StopSpam()
        {
            SpamTimer.Stop();
            SpamStatus.Text = "Off";
            SpamBTN.Text = "Start";
        }

        private void milisec_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = $"Miliseconds: {milisec.Value}";
            if (SpamTimer.Enabled) StopSpam();
        }

        private void SpamTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SpamTimer.Enabled) StopSpam();
        }

        private void SpamTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(SpamTextBox.Text);
            SendKeys.Send("{ENTER}");
        }

        private void SpamBTN_Click(object sender, EventArgs e)
        {
            if (SpamBTN.Text == "Start")
            {
                SpamTimer.Interval = milisec.Value;
                SpamStatus.Text = "On";
                SpamTimer.Start();
                SpamBTN.Text = "Stop";
            }
            else StopSpam();
        }
    }
}
