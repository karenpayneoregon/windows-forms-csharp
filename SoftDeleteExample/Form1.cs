using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftDeleteExample.Dialogs;

namespace SoftDeleteExample
{
    public partial class Form1 : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            bindingSource.DataSource = DataOperations.LoadTheaters();
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns["IsDeleted"].Visible = false;
            dataGridView1.UserDeletingRow += DataGridView1OnUserDeletingRow;
        }

        private void DataGridView1OnUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = PromptToRemoveRow();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            PromptToRemoveRow();
        }

        private bool PromptToRemoveRow()
        {
            Theater theater = (Theater)bindingSource.Current;
            if (!Question($"Remove {theater.Movie}"))
            {
                return true;
            }
            else
            {
                if (DataOperations.RemoveRow(theater.Id))
                {
                    bindingSource.RemoveCurrent();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public class Theater
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public string Movie { get; set; }
    }

 
}
