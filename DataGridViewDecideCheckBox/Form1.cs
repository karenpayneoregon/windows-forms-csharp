using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDecideCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;

            dataGridView1.CellContentClick += DataGridView1OnCellContentClick;
            dataGridView1.CellValueChanged += DataGridView1OnCellValueChanged;

        }

        private void DataGridView1OnCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void OnShown(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(false, "1");
            dataGridView1.Rows.Add(false, "0");
        }

        private void DataGridView1OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["CheckColumn"].Index && e.RowIndex != -1)
            {
                Console.WriteLine($"Row:{e.RowIndex}:Col:{e.ColumnIndex} is {Convert.ToBoolean(dataGridView1[e.ColumnIndex, e.RowIndex].Value)}");
            }

            Console.WriteLine(dataGridView1[e.ColumnIndex, e.RowIndex].ValueType);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value) == "1")
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightGray;
                dataGridView1.Rows[e.RowIndex].Cells[0].ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(false, "1");
            dataGridView1.Rows.Add(false, "0");
        }
    }

    static class Extensions
    {
        public static bool IsComboBoxCell(this DataGridViewCell sender)
        {
            bool Result = false;
            if (sender.EditType != null)
            {
                if (sender.EditType == typeof(DataGridViewComboBoxEditingControl))
                {
                    Result = true;
                    
                }
            }
            return Result;
        }
        public static string GetComboBoxValue(this DataGridViewRow row, string ColumnName)
        {
            return Convert.ToString((row.Cells[ColumnName] as DataGridViewComboBoxCell).FormattedValue.ToString());
        }
    }
}
