using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeSample_1
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
            comboBox1.DataSource = Enumerable.Range(1, 100).ToList();
            comboBox2.DataSource = Enumerable.Range(50, 500).ToList();

            comboBox1.SelectionChangeCommitted += ComboBoxOnSelectionChangeCommitted;
            comboBox2.SelectionChangeCommitted += ComboBoxOnSelectionChangeCommitted;
            SelectionChange_C1_C2();

            List<NumberItem> numberItems = new List<NumberItem>();
            for (int index = 5; index < 10; index++)
            {
                numberItems.Add(new NumberItem()
                {
                    Display = index.ToString("$#,##0.00"), 
                    Value = index
                });
            }

            comboBox3.DataSource = numberItems;
            comboBox3.SelectionChangeCommitted += ComboBox3OnSelectionChangeCommitted;
            Combo3Changed();

        }

        private void ComboBox3OnSelectionChangeCommitted(object sender, EventArgs e)
        {
            Combo3Changed();
        }

        private void Combo3Changed()
        {
            label3.Text = ((NumberItem)comboBox3.SelectedItem).Value.ToString();
        }

        private void ComboBoxOnSelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectionChange_C1_C2();
        }

        private void SelectionChange_C1_C2()
        {
            var c1 = (int)comboBox1.SelectedItem;
            var c2 = (int)comboBox2.SelectedItem;
            label1.Text = $"Combo 1: {c1} Combo 2: {c2}";
            var test = c1 * c2;
            label2.Text = test.ToString();
        }
    }

    public class NumberItem
    {
        public string Display { get; set; }
        public int Value { get; set; }
        public override string ToString() => Display;
    }
}
