using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

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
            // Set the visibility of pictureBox1 to true
            pictureBox1.Visible = true;

            // Set the visibility of pictureBox2 to false
            pictureBox2.Visible = false;
        }

        private async Task DisplayBlynkCloudData()
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
                    // webBrowser1.DocumentText = FormatAsHtml(responseData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatAsHtml(string data)
        {
            // Basic HTML formatting to display JSON data
            return $"<html><body><pre>{data}</pre></body></html>";
        }

        private void GeneratePDFReport(string outputPath)
        {
            try
            {
                // Create a new document
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                doc.Open();

                // Add content to the PDF
                // Title
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                Paragraph title = new Paragraph("IOT Sensor Readings Report", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                doc.Add(title);

                // Add readings for different time intervals
                AddSectionToPDF(doc, "Past 1 Hour", GetFakeReadingsForPastHour());
                AddSectionToPDF(doc, "Past 1 Day", GetFakeReadingsForPastDay());
                AddSectionToPDF(doc, "Past 3 Days", GetFakeReadingsForPastThreeDays());
                AddSectionToPDF(doc, "Past 1 Week", GetFakeReadingsForPastWeek());
                AddSectionToPDF(doc, "Past 1 Month", GetFakeReadingsForPastMonth());

                // Close the document
                doc.Close();

                MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddSectionToPDF(Document doc, string title, string readings)
        {
            // Add title
            Font sectionTitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
            Paragraph sectionTitle = new Paragraph(title, sectionTitleFont);
            sectionTitle.SpacingAfter = 10f;
            doc.Add(sectionTitle);

            // Add readings
            Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);
            Paragraph sectionContent = new Paragraph(readings, contentFont);
            doc.Add(sectionContent);
        }

        private string GetFakeReadingsForPastHour()
        {
            Random rnd = new Random();
            return $"Temperature: {rnd.Next(35, 49)}°C\nHumidity: {rnd.Next(40, 60)}%\nPressure: {rnd.Next(1000, 1010)} hPa";
        }

        private string GetFakeReadingsForPastDay()
        {
            Random rnd = new Random();
            return $"Average Temperature: {rnd.Next(35, 49)}°C\nAverage Humidity: {rnd.Next(35, 50)}%\nAverage Pressure: {rnd.Next(990, 1005)} hPa";
        }

        private string GetFakeReadingsForPastThreeDays()
        {
            Random rnd = new Random();
            return $"Average Temperature: {rnd.Next(35, 49)}°C\nAverage Humidity: {rnd.Next(30, 45)}%\nAverage Pressure: {rnd.Next(980, 995)} hPa";
        }

        private string GetFakeReadingsForPastWeek()
        {
            Random rnd = new Random();
            return $"Average Temperature: {rnd.Next(35, 49)}°C\nAverage Humidity: {rnd.Next(25, 40)}%\nAverage Pressure: {rnd.Next(970, 985)} hPa";
        }

        private string GetFakeReadingsForPastMonth()
        {
            Random rnd = new Random();
            return $"Average Temperature: {rnd.Next(35, 49)}°C\nAverage Humidity: {rnd.Next(20, 35)}%\nAverage Pressure: {rnd.Next(960, 975)} hPa";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Add your logic here
        }
        private void button17_Click(object sender, EventArgs e)
        {
            // Generate a unique file name with date and time
            string fileName = $"report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            // Generate the PDF report
            GeneratePDFReport(outputPath);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with the specified message
            MessageBox.Show("Upgrade current plan to access this feature", "Upgrade Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Firewall firewall = new Firewall();
            this.Hide();
            // Show the Pingfence form
            firewall.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Pingfence pingfence = new Pingfence();
            this.Hide();
            // Show the Pingfence form
            pingfence.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            UtilityTools utilityTools = new UtilityTools();
            this.Hide();
            // Show the Pingfence form
            utilityTools.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Cloudconsole cloudconsole = new Cloudconsole();
            this.Hide();
            // Show the Pingfence form
            cloudconsole.Show();

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
