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

namespace SqlDemos
{
    public partial class DataGridViewWithImageForm : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        public DataGridViewWithImageForm()
        {
            InitializeComponent();
            Text = "Code sample";
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            bindingSource.DataSource = DataOperations.GetCategories();
            dataGridView1.DataSource = bindingSource;
        }

        private void GetImageButton_Click(object sender, EventArgs e)
        {
            byte[] imageArray = ((DataRowView)bindingSource.Current).Row.Field<byte[]>("Picture");

            EditForm f = new EditForm(imageArray);
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
        
    }
}
