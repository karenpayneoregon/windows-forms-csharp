using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableAdapterSample.Classes;

namespace TableAdapterSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.northDataSet);
            var temp = northDataSet.Products;
            Console.WriteLine();
        }


        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            suppliersTableAdapter.FillByComboBox(northDataSet.Suppliers);

            categoriesTableAdapter.Fill(northDataSet.Categories);
            productsDataGridView.AutoGenerateColumns = false;
            productsTableAdapter.FillByCustom(northDataSet.Products);
            productsDataGridView.DataSource = productsBindingSource;

            categoriesTableAdapter.Fill(northDataSet.Categories);

            NorthDataSet.CategoriesRow categoryRow = northDataSet.Categories.NewCategoriesRow();
            categoryRow.CategoryID = -1;
            categoryRow.CategoryName = "Select/None";
            northDataSet.Categories.Rows.InsertAt(categoryRow, 0);
            categoriesBindingSource.Position = 0;

            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBoxOnSelectedIndexChanged;


            NorthDataSet.SuppliersRow suppliersRow = northDataSet.Suppliers.NewSuppliersRow();
            suppliersRow.SupplierID = -1;
            suppliersRow.CompanyName = "Select/None";
            northDataSet.Suppliers.Rows.InsertAt(suppliersRow,0);
            suppliersBindingSource.Position = 0;

            SuppliersComboBox.SelectedIndexChanged += SuppliersComboBoxOnSelectedIndexChanged;

            productsDataGridView.ExpandColumns();

        }

        private void SuppliersComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            BuildSearch();
        }

        private void CategoriesComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            BuildSearch();
        }

        /// <summary>
        /// Using foreign keys build search/filter. Needs a good deal of work
        /// </summary>
        private void BuildSearch()
        {
            if (CategoriesComboBox.SelectedItem == null || 
                SuppliersComboBox.SelectedItem == null) return;

            string filter = "";
            var categoryId = ((DataRowView)CategoriesComboBox.SelectedItem).Row.Field<int>("CategoryID");

            if (categoryId > -1)
            {
                filter += $"CategoryID = {categoryId}";
            }

            var suppliersId = ((DataRowView)SuppliersComboBox.SelectedItem).Row.Field<int>("SupplierID");

            if (suppliersId == -1 && string.IsNullOrWhiteSpace(filter))
            {
                filter += $"SupplierID = {suppliersId}";
            }
            else if(suppliersId > -1 && !string.IsNullOrWhiteSpace(filter))
            {
                filter += $" AND SupplierID = {suppliersId}";
            }

            productsBindingSource.Filter = filter;

            Console.WriteLine(filter);

        }

        /// <summary>
        /// Hard wired for showing what needs to be done in <see cref="BuildSearch"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestFilterButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "CategoryID = 2 AND SupplierID = 2";
        }

        private void RemoveFilterButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "";
        }
    }
}
