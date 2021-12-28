using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SelectRandomFile.Classes;

namespace SelectRandomFile
{

    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            SelectButton.Enabled = false;
            label1.Text = "";
        }
        
        private void SelectButton_Click(object sender, EventArgs e)
        {
            var fileItemsList = ((List<FileItem>) _bindingSource.DataSource);
            
            fileItemsList.Shuffle();
            
            var fileItem = fileItemsList.FirstOrDefault(item => item.Selected == false);
            if (fileItem != null)
            {
                fileItem.Selected = true;
                listBox1.Items.Add(fileItem.FileName);
            }


            var count = fileItemsList.Count(item => item.Selected == false);

            label1.Text = $"{count} not select of {fileItemsList.Count}";

            if (count != 0) return;
            SelectButton.Enabled = false;
            LoadButton.Enabled = true;

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string folderName = "C:\\OED";

            if (!Directory.Exists(folderName)) return;
            
            //listBox1.Items.Clear();
            label1.Text = "";

            SelectButton.Enabled = true;

            var result = FileOperations.GetFilesFromPath(folderName);
            _bindingSource.DataSource = result;

            //LoadButton.Enabled = false;
        }
    }
}
