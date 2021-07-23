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
using static ListBoxFromFileList.Dialogs;

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
            _BindingSource.PositionChanged += BindingSourceOnPositionChanged;
            
            Closing += OnClosing;

            PositionChanged();
        }
        

        private void BindingSourceOnPositionChanged(object sender, EventArgs e)
        {
            PositionChanged();
        }

        private void PositionChanged()
        {
            if (_BindingSource.Current == null) return;

            var current = ((FileItem) _BindingSource.Current);
            Console.WriteLine(current.FileName);
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Current != null)
            {
                if (Question("Remove current item?"))
                {
                    _BindingSource.RemoveCurrent();
                }
            }
        }

        /// <summary>
        /// Quickie example to show files for selected item in list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Current == null) return;
            
            var current = ((FileItem)_BindingSource.Current);


            if (!Directory.Exists(current.FolderName)) return;
            
            var files = Directory.GetFiles(current.FolderName);
            Console.WriteLine($"Files for {current.FolderName}");
            foreach (var file in files)
            {
                Console.WriteLine($"\t{file}");
            }

        }
    }
}
