using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeServices.UserControls
{
    public partial class DiscordTools : UserControl
    {
        public DiscordTools()
        {
            InitializeComponent();
        }

        private static WebClient WebClient { get; set; }

        private static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient = new WebClient())
                return WebClient.UploadValues(uri, pairs);
        }

        private static void sendWebHook(string URL, string msg, string username)
        {
            Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }

        private void DiscordTools_Load(object sender, EventArgs e)
        {

        }

        private void SpamTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                sendWebHook((url.Text), string.Concat(new string[] { msg.Text }), name.Text);
                LogsBox.AppendText("Message Sent Successfuly! - " + time + Environment.NewLine);
            }
            catch
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                LogsBox.AppendText("Failed To Send Message - " + time + Environment.NewLine);
                SpamTimer.Stop();
                Alert.Show("Discord Tools", "Someting went wrong while sending a message");
                SpamBTN.Text = "Stop Spam";
            }
        }

        private void SpamBTN_Click(object sender, EventArgs e)
        {
            if (SpamBTN.Text == "Start Spam")
            {
                SpamTimer.Start();
                SpamBTN.Text = "Stop Spam";
            }
            else
            {
                SpamTimer.Stop();
                SpamBTN.Text = "Start Spam";
            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                sendWebHook((url.Text), string.Concat(new string[] { msg.Text }), name.Text);
                LogsBox.AppendText("Message Sent Successfuly! - " + time + Environment.NewLine);
            }
            catch
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                LogsBox.AppendText("Failed To Send Message - " + time + Environment.NewLine);
            }
        }

        private void ClearAttackLogs_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(url.Text);
                webRequest.Method = "DELETE";
                HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
                Alert.Show("Discord Tools", "Delete Request To Given Webhook Has Been Sent");
            }
            catch { }
        }
    }
}
