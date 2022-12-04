using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class Form2 : Form
    {
        readonly Operations _operations = new Operations();
        readonly BindingSource _customerBindingSource = new BindingSource();
        readonly BindingSource _colorBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Setup();
            //CustomersDataGridView.AllowUserToAddRows = false;

        }
        private void Setup()
        {
            var (customerTable, colorTable) = _operations.LoadData();

            _colorBindingSource.DataSource = colorTable;
            ColorComboBoxColumn.DisplayMember = "ColorText";
            ColorComboBoxColumn.ValueMember = "ColorId";
            ColorComboBoxColumn.DataPropertyName = "ColorId";
            ColorComboBoxColumn.DataSource = _colorBindingSource;
            ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            CustomersDataGridView.AutoGenerateColumns = false;

            ItemTextBoxColumn.DataPropertyName = "Item";
            _customerBindingSource.DataSource = customerTable;

            CustomersDataGridView.DataSource = _customerBindingSource;
            CustomersDataGridView.DefaultValuesNeeded += CustomersDataGridViewOnDefaultValuesNeeded;

        }

        private void CustomersDataGridViewOnDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ColorComboBoxColumn"].Value = 1;
        }
    }
}
