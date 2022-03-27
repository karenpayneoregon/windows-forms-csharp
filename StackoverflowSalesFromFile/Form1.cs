using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackoverflowSalesFromFile.Classes;

namespace StackoverflowSalesFromFile
{
    public partial class Form1 : Form
    {
        List<Sales> sales = new List<Sales>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var (salesList, invalidLines) = FileOperations.LoadSalesFromFile();
            if (invalidLines.Count > 0)
            {
                dgvSales.Enabled = false;
                MessageBox.Show($"There are {invalidLines} lines which did not convert");
            }
            else
            {
                bs.DataSource = salesList;
                dgvSales.DataSource = bs;
            }
        }
    }
}
