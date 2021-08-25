using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataGridViewProgressBar.Classes;

namespace LoadDataGridViewProgressBar
{
    public partial class Form1 : Form
    {
        public readonly BindingSource _customersBindingSource = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
            
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var (exception, dataTable) = await Operations.LoadCustomerData();
            
            try
            {
                if (exception == null)
                {
                    _customersBindingSource.DataSource = dataTable;
                    customerDataGridView.DataSource = _customersBindingSource;
                }
                else
                {
                    CurrentButton.Enabled = false;
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.MarqueeAnimationSpeed = 0;
                panel1.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_customersBindingSource.Current == null) return;
            
            // access fields from the DataRow
            var data = ((DataRowView) _customersBindingSource.Current).Row;

            MessageBox.Show($"{data.Field<int>("CustomerIdentifier")}");
        }
    }
}
