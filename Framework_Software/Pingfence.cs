using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Pingfence
{
    public partial class Pingfence : Form
    {
        public Timer fadeInTimer;
        public double currentOpacity;
        public bool pictureBoxVisible = false;
        public string labelText = "";
        public Pingfence()
        {
            InitializeComponent();
        }

        public void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void Pingfence_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }


        public void button2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            // Define the URL you want to open
            string url = "https://pingfence.com"; // Replace "https://example.com" with the actual URL you want to open

            // Open the URL in the default browser
            Process.Start(url);
        }

        public void button7_Click(object sender, EventArgs e)
        {

        }

        public void tableLayoutPanel7_Paint_2(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }






        private void tableLayoutPanel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        public void button4_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            VirusScan VirusScan = new VirusScan();
            this.Hide();
            // Show the Pingfence form
            VirusScan.Show();
        }

        public void label7_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            QuickScan QuickScan = new QuickScan();
            this.Hide();
            // Show the Pingfence form
            QuickScan.Show();
        }

        public void pictureBox9_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            QuickScan QuickScan = new QuickScan();
            this.Hide();
            // Show the Pingfence form
            QuickScan.Show();
        }

        public void label11_Click(object sender, EventArgs e)
        {

        }

        public void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Pingfence Pingfence = new Pingfence();
            this.Hide();
            // Show the Pingfence form
            Pingfence.Show();
        }

        public void button7_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            SpeedUp SpeedUp = new SpeedUp();
            this.Hide();
            // Show the Pingfence form
            SpeedUp.Show();
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            FullScan FullScan = new FullScan();
            this.Hide();
            // Show the Pingfence form
            FullScan.Show();
        }

        private void tableLayoutPanel7_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox3_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void button14_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void button13_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Firewall firewall = new Firewall();
            this.Hide();
            // Show the Pingfence form
            firewall.Show();

        }

        public void button12_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Cloudconsole organizations = new Cloudconsole();
            this.Hide();
            // Show the Pingfence form
            organizations.Show();
        }

        public void button15_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            UtilityTools utilitytools = new UtilityTools();
            this.Hide();
            // Show the Pingfence form
            utilitytools.Show();
        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button9_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void pictureBox7_Click_2(object sender, EventArgs e)
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

        public void pictureBox5_Click_2(object sender, EventArgs e)
        {
            // Minimize the application window
            this.WindowState = FormWindowState.Minimized;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            QuickScan quickScan = new QuickScan();
            this.Hide();
            quickScan.Show();

            label9.Text = "You are Safe";

            // Update the state variables
            pictureBoxVisible = pictureBox24.Visible;
            labelText = label9.Text;
        }

        public void label2_Click_2(object sender, EventArgs e)
        {
            QuickScan quickScan = new QuickScan();
            this.Hide();
            quickScan.Show();

            label9.Text = "You are Safe";

            // Update the state variables
            pictureBoxVisible = pictureBox24.Visible;
            labelText = label9.Text;
        }

        // Add this method to restore the state when navigating back
        public void RestoreState()
        {
            label9.Text = labelText;
        }

        public void label3_Click_2(object sender, EventArgs e)
        {
            FullScan fullScan = new FullScan();
            this.Hide();
            fullScan.Show();
        }

        public void pictureBox3_Click_1(object sender, EventArgs e)
        {
            FullScan fullScan = new FullScan();
            this.Hide();
            fullScan.Show();
        }

        public void label6_Click_1(object sender, EventArgs e)
        {
            Activation activation = new Activation();
            //this.Hide();
            activation.Show();
        }

        public void label4_Click_1(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void pictureBox8_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void label8_Click_2(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void pictureBox9_Click_1(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void pictureBox4_Click_2(object sender, EventArgs e)
        {
            Activation activation = new Activation();
            //this.Hide();

            activation.Show();
        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_3(object sender, EventArgs e)
        {

        }

        public void label16_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void pictureBox10_Click_1(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void pictureBox11_Click_1(object sender, EventArgs e)
        {
            GoPremium goPremium = new GoPremium();
            this.Hide();
            goPremium.Show();
        }

        public void pictureBox14_Click(object sender, EventArgs e)
        {
            // Define the URL you want to redirect to
            string websiteUrl = "https://www.pingfence.com";

            // Open the URL in the default browser
            System.Diagnostics.Process.Start(websiteUrl);
        }

        public void label9_Click_1(object sender, EventArgs e)
        {

        }

        public void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox25.Visible = false;

            // Stop the timer
            timer1.Stop();
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click_2(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_4(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
