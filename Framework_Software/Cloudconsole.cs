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
    public partial class Cloudconsole : Form
    {
        public Cloudconsole()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Pingfence Pingfence = new Pingfence();
            this.Hide();
            // Show the Pingfence form
            Pingfence.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Developertools developerstools = new Developertools();
            this.Hide();
            // Show the Pingfence form
            developerstools.Show();
        }
    }
}
