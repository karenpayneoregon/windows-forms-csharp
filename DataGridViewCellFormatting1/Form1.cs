using System;
using System.Drawing;
using System.Windows.Forms;
using DataGridViewCellFormatting1.Classes;

namespace DataGridViewCellFormatting1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MockedDataTable.Table();
            dataGridView1.CellFormatting += DataGridView1OnCellFormatting;
        }

        private const string _amountColumnName = "Amount";
        private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dataGridView1.Columns[e.ColumnIndex].Name.Equals(_amountColumnName)) return;
            if (e.Value == null || !int.TryParse(e.Value.ToString(), out var amount)) return;
            
            dataGridView1.Rows[e.RowIndex].Cells[_amountColumnName].Style.BackColor = amount >0 ? 
                Color.Empty : 
                Color.Red;
        }
    }
}
