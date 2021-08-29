using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataGridViewProgressBar.Classes;


namespace LoadDataGridViewProgressBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var (_, dataTable) = await Operations.LoadCustomerData();

            Setup(dataTable);
        }

        private void Setup(DataTable dataTable)
        {
            CustomersBindingSource.DataSource = dataTable;
            customerDataGridView.DataSource = CustomersBindingSource;

            customerDataGridView.ExpandColumns(true);

            NextButton.Click += (sender, args) => CustomersBindingSource.MoveNext();

            PreviousButton.Click += (sender, args)
                => CustomersBindingSource.MovePrevious();

            EditButton.Click += EditButtonOnClick;

            CustomersBindingSource.PositionChanged += (sender, args) =>
            {
                NextButton.Enabled = CustomersBindingSource.Position < CustomersBindingSource.Count - 1;
                PreviousButton.Enabled = CustomersBindingSource.Position > 0;
            };
        }

        private void EditButtonOnClick(object sender, EventArgs e)
        {
            if (CustomersBindingSource.Current == null) return;
            DataRow row = ((DataRowView) CustomersBindingSource.Current).Row;
            MessageBox.Show($"Go do something with {row.Field<int>("CustomerIdentifier")}");
        }
    }
}
