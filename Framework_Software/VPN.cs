using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingfence
{
    public partial class VPN : Form
    {
        public VPN()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Define the URL you want to redirect to
            string websiteUrl = "https://www.pingfence.com";

            // Open the URL in the default browser
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pingfence pingfence = new Pingfence();
            this.Hide();
            pingfence.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UtilityTools utilityTools = new UtilityTools();
            this.Hide();
            utilityTools.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
