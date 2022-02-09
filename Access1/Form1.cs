using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dataSet1.Person);

        }

        private void personBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }

private void personDataGridView_DefaultValuesNeeded(
    object sender, DataGridViewRowEventArgs e)
{
    e.Row.Cells["CreatedByColumn"].Value = Environment.UserName;
}
    }
}
