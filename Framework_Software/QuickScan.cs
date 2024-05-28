using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace Pingfence
{
    public partial class QuickScan : Form
    {
        public QuickScan()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Pingfence Pingfence = new Pingfence();
            this.Hide();
            // Show the Pingfence form
            Pingfence.Show();
            
        }

        private void QuickScan_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) 
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
            pictureBox1.Visible = true;

            // Set up the progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Determine the platform and set up the process accordingly
            string shell;
            string arguments;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                shell = "powershell.exe";
                arguments = "-NoExit -Command \"Get-Process\""; // Example command
            }
            else
            {
                shell = "/bin/bash";
                arguments = "-c \"ps aux\""; // Example command
            }

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = shell,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            int outputLinesCount = 0;

            process.OutputDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    outputLinesCount++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(ev.Data + Environment.NewLine);
                        UpdateProgressBar(outputLinesCount);

                        // Check if the output indicates a malicious file
                        if (IsMalicious(ev.Data))
                        {
                            richTextBox1.AppendText(ev.Data + Environment.NewLine);
                        }
                        else
                        {
                            richTextBox1.AppendText(ev.Data + Environment.NewLine);
                        }
                    });
                }
            };

            process.ErrorDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText("ERROR: " + ev.Data + Environment.NewLine);
                    });
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private void UpdateProgressBar(int outputLinesCount)
        {
            // Increment the progress bar value based on the number of lines read
            int progressValue = Math.Min(outputLinesCount, progressBar1.Maximum);
            progressBar1.Value = progressValue;
        }

        // Example method to determine if the file is malicious
        private bool IsMalicious(string outputLine)
        {
            // This is a placeholder. Replace with actual logic to determine if the file is malicious.
            // For example, if the output contains a specific keyword or matches a certain pattern.
            return outputLine.Contains("malicious"); // Example condition
        }




        private void timer1_Tick(object sender, EventArgs e)
        {


        }


        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar2.Increment(1);
            if (progressBar1.Value == 100 & progressBar2.Value == 100 )
            {
                timer1.Stop();
                MessageBox.Show("Scan Complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Define the URL you want to redirect to
            string websiteUrl = "https://www.pingfence.com";

            // Open the URL in the default browser
            System.Diagnostics.Process.Start(websiteUrl);
        }

        private void button8_Click_1(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Minimize the application window
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
