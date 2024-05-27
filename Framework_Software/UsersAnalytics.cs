using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingfence
{
    public partial class UsersAnalytics : Form
    {
        public UsersAnalytics()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the visibility of pictureBox1 to true
            pictureBox1.Visible = true;

            // Set the visibility of pictureBox2 to false
            pictureBox2.Visible = false;
        }

        private async Task pictureBox1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // Make a request to the Blynk Cloud API
                string apiKey = "e3QcQDQfWk7abn_eZlMoBpHuPxaDtli-"; // Replace with your Blynk API key
                string apiUrl = $"https://blynk-cloud.com/{apiKey}/get/v1/data";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    // Read and parse the response
                    string responseData = await response.Content.ReadAsStringAsync();

                    // Display the data in a web browser control
                    webBrowser1.DocumentText = responseData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                // Set the visibility of pictureBox1 to true
                pictureBox2.Visible = true;

                // Set the visibility of pictureBox2 to false
                pictureBox1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Set the visibility of pictureBox1 to true
            pictureBox2.Visible = true;

            // Set the visibility of pictureBox2 to false
            pictureBox1.Visible = false;
        }
    }
}
