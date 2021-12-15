using System;
using System.IO;
using System.Windows.Forms;
using static RemoveMarkOfWeb.Classes.Utilities;

namespace RemoveMarkOfWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FolderTextBox.Text))
            {
                UnblockFiles(FolderTextBox.Text);
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show(@"Folder provided does not exists or no folder specified");
            }
        }

    }
}
