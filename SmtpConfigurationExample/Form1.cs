using System;
using System.Text;
using System.Windows.Forms;
using SmtpConfigurationExample.Classes;
using static System.Configuration.ConfigurationManager;

namespace SmtpConfigurationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetEmailSettingsButton_Click(object sender, EventArgs e)
        {
            var mc = new MailConfiguration();
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"User name: {mc.UserName}");
            builder.AppendLine($"From: {mc.FromAddress}");
            builder.AppendLine($"Host: {mc.Host}");
            builder.AppendLine($"Port: {mc.Port}");

            ResultsTextBox.Text = builder.ToString();

        }

        private void GetConnectionButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Text = ConnectionStrings["Tournaments"].ConnectionString;
        }

        private void FilePathButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Text = AppSettings["filePath"];
        }
    }
}
