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
    public partial class greet : Form
    {
        private Timer timer;

        public greet()
        {
            InitializeComponent();

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer to prevent further ticks
            timer.Stop();

            // Show the Dashboard.cs form
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();

            // Close the current form (pingfence.cs)
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle any click events for the pictureBox1 if needed
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
