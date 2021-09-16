using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewCheckedSum
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = 
            new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {

            // Mocked data for demonstration of getting checked and sum
            _bindingSource.DataSource = new List<ItemRecord>()
            {
                new ItemRecord() {Selected = false, Value = 10},
                new ItemRecord() {Selected = false, Value = 5},
                new ItemRecord() {Selected = false, Value = 20},
                new ItemRecord() {Selected = false, Value = 15},
            };

            dataGridView1.DataSource = _bindingSource;
            
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[0].Width = 30;
        }


        /// <summary>
        /// Get checked from column 0, get sum of second column
        /// and display sum or nothing if nothing checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCheckedButton_Click(object sender, EventArgs e)
        {
            var results = ((List<ItemRecord>)_bindingSource.DataSource)
                .Where(itemRecord => itemRecord.Selected).ToList();

            sumTextBox.Text = results.Count == 0 ? 
                "" : 
                $"{results.Sum(itemRecord => itemRecord.Value)}";

        }

        private void CurrentRowButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                ItemRecord current = (ItemRecord)_bindingSource.Current;
                MessageBox.Show($"{(current.Selected ? "Yes" : "No")} {current.Value}");
            }
            else
            {
                MessageBox.Show("No current row");
            }
        }
    }

    /// <summary>
    /// Place in it's own class file
    /// </summary>
    class ItemRecord
    {
        public bool Selected { get; set; }
        public double Value { get; set; }
    }
}
