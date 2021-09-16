using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAnnotationsEntityFrameworkCoreDates.Classes;
using DataAnnotationsEntityFrameworkCoreDates.DbContext;

namespace DataAnnotationsEntityFrameworkCoreDates
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            using var context = new Context();
            var people = context.Person1.ToList();

            _bindingSource.DataSource = people;
            dataGridView1.DataSource = _bindingSource;

            dataGridView1.DataError += DataGridView1OnDataError;
        }

        private void DataGridView1OnDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message.Contains("not recognized as a valid DateTime"))
            {
                e.Cancel = true;
                
                MessageBox.Show("Not a date, correct or press ESC");
            }
            
        }



        private void ReadPeopleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
