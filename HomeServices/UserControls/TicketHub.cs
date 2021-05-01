using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fusion;
using HomeServices.Helpers.Discord;

namespace HomeServices.UserControls
{
    public partial class TicketHub : UserControl
    {
        public TicketHub()
        {
            InitializeComponent();
        }

        private static bool HasATicket = false;

        private async void TicketHub_Load(object sender, EventArgs e)
        {
            HasATicket = false;
            var resp = await FusionApp.GetAppVar("TicketBlacklist");
            if (resp.Contains("Invalid Var"))
            {
                SendNewTicketBTN.Enabled = false;
                Alert.Show("Auth Error", "Unknown error, please refresh the page");
            }
            else if (resp.Contains(User.UserId))
            {
                SendNewTicketBTN.Enabled = false;
                Alert.Show("Ticket Blacklist", "You have been permanently blacklisted from tickets, please contact administrator/owners for more information");
            }
            else
            {
                var DidAdminRepond = await FusionApp.GetUserVar("TicketReponded");
                if (DidAdminRepond.Error)
                {
                    var GetText = await Helpers.Client.Http.Get(await FusionApp.GetAppVar("TicketLink") + User.Username + ".txt");
                    if (!GetText.Error)
                    {
                        if (GetText.Response.Contains("<!doctype html>")) TicketBox.Text = "Last ticket not found or it's not answered by Admin";
                        else TicketBox.Text = GetText.Response;
                    }
                    else
                    {
                        TicketBox.Text = "Error: Unable to load ticket text, please refresh this page";
                    }
                }
                else
                {
                    HasATicket = true;
                    var GetText = await Helpers.Client.Http.Get(await FusionApp.GetAppVar("TicketLink") + User.Username + ".txt");
                    if (!GetText.Error)
                    {
                        if (GetText.Response.Contains("<!doctype html>")) TicketBox.Text = "Please wait for admin response...";
                        else TicketBox.Text = GetText.Response;
                    }
                    else
                    {
                        TicketBox.Text = "Error: Unable to load ticket text, please refresh this page";
                    }
                }
            }
        }

        private async void SendNewTicketBTN_Click(object sender, EventArgs e)
        {
            if (SendNewTicketBTN.Text != "Send") return;

            SendNewTicketBTN.Text = "Please wait...";
            if (HasATicket)
            {
                Alert.Show("Ticket Info", "You already have one ticket that is not answered, please wait");
                SendNewTicketBTN.Text = "Send";
            }
            else if (string.IsNullOrWhiteSpace(title.Text) || string.IsNullOrWhiteSpace(message.Text) || message.Text.Length >= 200 || title.Text.Length >= 200)
            {
                Alert.Show("Missing Arguments", "Please enter title and message text to send ticket");
                SendNewTicketBTN.Text = "Send";
            }
            else if (HasATicket == false)
            {
                HasATicket = true;
                var sendticket = await WebhookTool.Ticket(message.Text, title.Text);
                if (!sendticket.Error)
                {
                    await FusionApp.SetUserVar("TicketReponded", $"NO - Title: {title.Text} - Msg: {message.Text}");
                    TicketBox.Text = "Ticket has been sent...";
                    Alert.Show("Thank you", "Your ticket has been submitted, please wait for response");
                    SendNewTicketBTN.Text = "Send";
                }
                else
                {
                    Alert.Show("Ticket Error", "Something went wrong while sending a ticket please try again");
                    SendNewTicketBTN.Text = "Send";
                }
            }
        }
    }
}
