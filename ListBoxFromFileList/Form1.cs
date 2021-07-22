using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListBoxFromFileList.Classes;
using Newtonsoft.Json;

namespace ListBoxFromFileList
{
    public partial class Form1 : Form
    {
        public BindingSource _BindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            JsonHelpers.InitializeData();
            
            _BindingSource.DataSource = JsonHelpers.Read();
            
            listBox1.DataSource = _BindingSource;
            
            listBox1.MouseDoubleClick += ListBox1OnMouseDoubleClick;
            
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            JsonHelpers.Save((List<FileItem>)_BindingSource.DataSource);
        }

        private void ListBox1OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_BindingSource.Current == null) return;
            
            if (!label1.Visible)
            {
                label1.Visible = true;
            }

            label1.Text = ((FileItem) _BindingSource.Current).FullName;

        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            _BindingSource.Add(new FileItem() {FullName = "D:\\Docs\\readme.md"});
        }
    }
}
