using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataGridViewGetCellSyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.CellFormatting += DataGridView1OnCellFormatting;
        }

        private void DataGridView1OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0) return;

            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == "Anne")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSalmon;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Karen");
            dataGridView1.Rows.Add("Anne");
            dataGridView1.Rows.Add("Karen");
            dataGridView1.Rows.Add("Anne");
            dataGridView1.Rows.Add("Mary");
            dataGridView1.Rows.Add("Anne");
        }

        private void IterateRowsButton_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();

            for (int index = 0; index < dataGridView1.Rows.Count -1; index++)
            {
                
                if (dataGridView1.Rows[index].IsNewRow)
                {
                    continue;
                }

                var cellStyle = dataGridView1.Rows[index].Cells[0].GetFormattedStyle();
                listBox1.Items.Add(cellStyle.Font.Bold ? $"{index} is bold" : $"{index} is not bold");
            }
            
        }
    }
}
