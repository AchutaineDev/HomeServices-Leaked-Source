using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeServices.Helpers;

namespace HomeServices.UserControls
{
    public partial class IPToolBox : UserControl
    {
        public IPToolBox()
        {
            InitializeComponent();
        }

        private void IPToolBox_Load(object sender, EventArgs e)
        {

        }

        private async void LocateBTN_Click(object sender, EventArgs e)
        {
            Alert.Show("Geo Location", await Tools.GeoLocateAsync(host.Text));
        }

        private void CheckPortBTN_Click(object sender, EventArgs e)
        {
            Alert.Show("Single Port Scan", Tools.CheckOpenPort(checkportTB.Text, porttocheck.Text));
        }

        private async void NmapBTN_Click(object sender, EventArgs e)
        {
            Alert.Show("Nmap Port Scanner", await Tools.NmapScan(Nmapscan.Text));
        }

        private async void StartZoneBTN_Click(object sender, EventArgs e)
        {
            Alert.Show("Zone Transfer", await Tools.ZoneLookup(zonetrafettb.Text));
        }

        private async void StartSubNetLookzpBTn_Click(object sender, EventArgs e)
        {
            Alert.Show("Subnet Lookup", await Tools.SubnetScan(sunbet.Text));
        }

        private async void StartDNSBTN_Click(object sender, EventArgs e)
        {
            Alert.Show("DNS Lookup", await Tools.DnsLookup(dns.Text));
        }
    }
}
