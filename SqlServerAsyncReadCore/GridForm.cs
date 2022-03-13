using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewUtilities.LanguageExtensions;
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore
{
    public partial class GridForm : Form
    {
        private readonly BindingSource bindingSource = new();
        private readonly CancellationTokenSource _cancellationTokenSource = new();
        public GridForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            bindingSource.DataSource = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);
            dataGridView1.DataSource = bindingSource;
            dataGridView1.ExpandColumns();

        }
    }
}
