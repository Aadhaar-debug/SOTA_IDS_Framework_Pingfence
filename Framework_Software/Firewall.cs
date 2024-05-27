using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pingfence
{
    public partial class Firewall : Form
    {
        private List<string> blockedIPs;

        public Firewall()
        {
            InitializeComponent();
            blockedIPs = new List<string>();
            StartFirewall();
            DisplayFirewallWebPage();
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
        }

        private void StartFirewall()
        {
            Task.Run(() =>
            {
                try
                {
                    var listener = new TcpListener(IPAddress.Any, 8080);
                    listener.Start();

                    while (true)
                    {
                        var client = listener.AcceptTcpClient();
                        var clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                        if (IsBlocked(clientIP))
                        {
                            string verboseInfo = $"Connection from {clientIP} blocked.";
                            DisplayVerboseInformation(verboseInfo);
                            client.Close();
                        }
                        else
                        {
                            string verboseInfo = $"Connection from {clientIP} accepted.";
                            DisplayVerboseInformation(verboseInfo);
                            // Handle the connection here
                        }
                    }
                }
                catch (Exception ex)
                {
                    string verboseInfo = $"Error: {ex.Message}";
                    DisplayVerboseInformation(verboseInfo);
                }
            });
        }

        private void DisplayFirewallWebPage()
        {
            webBrowser1.Navigate("http://192.168.29.1/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Check if the document completed is the one you're interested in
            if (e.Url.AbsoluteUri == "http://192.168.29.1/")
            {
                // Perform actions after the document has been loaded
                Console.WriteLine("Firewall web page loaded successfully.");
                // You can add any additional actions here
            }
        }

        private void DisplayVerboseInformation(string verboseInfo)
        {
            // Output verbose information to the console
            Console.WriteLine(verboseInfo);

            // Display verbose information in a label
            UpdateVerboseLabel(verboseInfo);
        }

        private void UpdateVerboseLabel(string verboseInfo)
        {
            // Update the label with verbose information
            if (InvokeRequired)
            {
                Invoke((Action)(() => UpdateVerboseLabel(verboseInfo)));
                return;
            }
           // verboseLabel.Text = verboseInfo;
        }

        private bool IsBlocked(string ipAddress)
        {
            return blockedIPs.Contains(ipAddress);
        }

        private void BlockIP(string ipAddress)
        {
            blockedIPs.Add(ipAddress);
        }

        private void UnblockIP(string ipAddress)
        {
            blockedIPs.Remove(ipAddress);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Add your code here
        }
    }
}
