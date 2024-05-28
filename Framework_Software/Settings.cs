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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {
            Pingfence pingfence = new Pingfence();
            this.Hide();
            pingfence.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UtilityTools utilityTools = new UtilityTools();
            this.Hide();
            utilityTools.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Minimize the application window
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Display a message box asking the user if they are sure they want to quit
            DialogResult result = MessageBox.Show("Are you sure you want to quit the program?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.OK)
            {
                // If the user clicks OK, close the program
                this.Close();
            }
            else
            {
                // If the user clicks Cancel, do nothing
            }

        }
    }
}
