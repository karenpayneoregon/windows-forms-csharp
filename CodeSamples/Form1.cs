using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSamples
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Populate()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;

            FirstNameListBox.DataSource = new List<string>() { "Karen", "Mary", "Jim" };
            LastNameListBox.DataSource = new List<string>() { "Payne", "Jones", "Smith" };

            for (int index = 0; index < FirstNameListBox.Items.Count; index++)
            {
                table.Rows.Add(new[] {FirstNameListBox.Items[index], LastNameListBox.Items[index] });
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Populate();
        }

        private void GetCurrentButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                DataRow row = ((DataRowView)bindingSource.Current).Row;
                MessageBox.Show($"{row.Field<string>("FirstName")} {row.Field<string>("LastName")}");
            }
        }
    }
}
