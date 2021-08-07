using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewCellFormatting1.Classes;

namespace DataGridViewCellFormatting1
{
    public partial class Form2 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            Shown += OnShown;
            
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /*
             * DbNull check
             */
            DataRowView drv = ((DataRowView)_bindingSource.Current);
            DataRow row = drv.Row;
            if (row["Amount"] == DBNull.Value)
            {
                return;
            }


            var test = dataGridView1.Rows[e.RowIndex].Cells[_amountColumnName].Value;

            if (test == null || !int.TryParse(test.ToString(), out var amount)) return;

            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = amount > 0 ?
                Color.Empty :
                Color.Red;



        }
        private void OnShown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = MockedDataTable.Table();
            dataGridView1.DataSource = _bindingSource;

            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            //dataGridView1.CellFormatting += DataGridView1OnCellFormatting;
        }
        private const string _amountColumnName = "Amount";
        private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
             * DbNull check
             */
            DataRowView drv = ((DataRowView)_bindingSource.Current);
            DataRow row = drv.Row;
            if (row["Amount"] == DBNull.Value)
            {
                return;
            }


            if (!dataGridView1.Columns[e.ColumnIndex].Name.Equals(_amountColumnName)) return;
            if (e.Value == null || !int.TryParse(e.Value.ToString(), out var amount)) return;

            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = amount > 0 ?
                Color.Empty :
                Color.Red;

            




        }
    }
}
