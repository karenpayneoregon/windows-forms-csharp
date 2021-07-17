using System;
using System.Windows.Forms;
using MediaFileDemo.Classes;
using static MediaFileDemo.Classes.Dialogs;

namespace MediaFileDemo
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;

        }

        private void OnShown(object sender, EventArgs e)
        {
            _bindingSource.LoadFromFile();
            listBox1.DataSource = _bindingSource;
        }

        private void GetFileNameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show(((MediaItem)listBox1.SelectedItem).FileName);
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _bindingSource.SaveToFile("Test.txt");
        }

        private void DeleteCurrentButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (Question("Delete"))
                {
                    _bindingSource.Remove((MediaItem)listBox1.SelectedItem);
                }
            }

        }
    }
}
