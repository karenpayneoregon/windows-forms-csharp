using System;
using System.Data;
using System.Windows.Forms;
using GroupbyDataTable.Classes;

namespace GroupbyDataTable
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
            dataGridView1.DataSource = Operations.Mocked();
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Operations
                .GroupData((DataTable)dataGridView1.DataSource);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Operations.Mocked();
        }
    }
}
