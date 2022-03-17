using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckedListBox1a.Classes;

namespace CheckedListBox1a
{
    public partial class Form1 : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        protected BindingList<Company> bindingList = new BindingList<Company>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = bindingList;
            dataGridView1.DataSource = bindingSource;

            checkedListBox1.DataSource = Mocked.Companies;
        }

        private void CheckedCompanyButton_Click(object sender, EventArgs e)
        {
            var result = checkedListBox1.CheckedList<Company>();

            if (result.Count <= 0) return;
            foreach (var company in result)
            {
                Console.WriteLine($"{company.Id, -5}{company.Name}");
            }
        }

        private void PopulateGridButton_Click(object sender, EventArgs e)
        {
            var result = checkedListBox1.CheckedList<Company>();

            if (result.Count <= 0) return;
            foreach (var company in result)
            {
                if (!bindingList.Contains(company))
                {
                    bindingList.Add(company);
                }
                
            }
        }

    }
}
