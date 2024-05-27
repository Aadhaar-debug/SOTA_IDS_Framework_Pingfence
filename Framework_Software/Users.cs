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
    public partial class Users : Form
    {
        private int panelCount = 0;

        public Users()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Event handler code for label9_Click (if needed)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Event handler code for button6_Click (if needed)
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (panelCount > 0)
            {
                // Remove the last added button
                panelCount--;
                string buttonName = "dynamicButton" + panelCount;
                Control buttonToRemove = panelButtons.Controls[buttonName];
                if (buttonToRemove != null)
                {
                    panelButtons.Controls.Remove(buttonToRemove);
                    buttonToRemove.Dispose();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new UserInputForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Create a new button with the input data
                    System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
                    newButton.Size = new Size(650, 30); // Set width to 650 pixels
                    newButton.Location = new Point(10, panelCount * 40);
                    newButton.Name = "dynamicButton" + panelCount;
                    newButton.Text = $"Name: {form.Name}, Email: {form.Email}, API Key: {form.ApiKey}, Auth Domain: {form.AuthDomain}, Project ID: {form.ProjectId}, Storage Bucket: {form.StorageBucket}, Messaging Sender ID: {form.MessagingSenderId}, App ID: {form.AppId}";
                    newButton.BackColor = Color.YellowGreen; // Set the background color of the button
                    newButton.ForeColor = Color.Black; // Set the text color of the button

                    // Add the new button to the panelButtons control
                    panelButtons.Controls.Add(newButton);

                    panelCount++;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            UsersAnalytics useranalytics = new UsersAnalytics();
            this.Hide();
            useranalytics.Show();
        }
    }
}
