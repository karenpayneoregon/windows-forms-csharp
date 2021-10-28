using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckListBoxProducts.Classes;

namespace CheckListBoxProducts
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var results = SqlServerOperations.ProductColumnNames().Split(',');
            foreach (var columnName in results)
            {
                checkedListBox1.Items.Add(columnName);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var names = checkedListBox1.SelectedColumnNames();
            if (names.Count >0)
            {

                var table = SqlServerOperations
                    .LoadProducts(
                        $"SELECT {string.Join(",", names.Select(x => x))} FROM dbo.Products");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
                dataGridView1.ExpandColumns();
            }
            else
            {
                dataGridView1.DataSource = null;
            }

        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem();
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem(false);
        }

        private void SelectAllColumnsButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < checkedListBox1.Items.Count; index++)
            {
                checkedListBox1.SetItemCheckState(index, ToggleStateCheckBox.Checked ? CheckState.Checked : CheckState.Unchecked);
            }
        }
    }


}
