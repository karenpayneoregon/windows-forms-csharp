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
}
