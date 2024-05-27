using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pingfence
{
    public partial class UserInputForm : Form
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string ApiKey { get; private set; }
        public string AuthDomain { get; private set; }
        public string ProjectId { get; private set; }
        public string StorageBucket { get; private set; }
        public string MessagingSenderId { get; private set; }
        public string AppId { get; private set; }

        public UserInputForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Email = txtEmail.Text;
            ApiKey = txtApiKey.Text;
            AuthDomain = txtAuthDomain.Text;
            ProjectId = txtProjectId.Text;
            StorageBucket = txtStorageBucket.Text;
            MessagingSenderId = txtMessagingSenderId.Text;
            AppId = txtAppId.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
