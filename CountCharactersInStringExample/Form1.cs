using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountExample.Classes;
using CountExample.Models;

namespace CountExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            var raw = @"7916,1465,8157,8772,5279,8812,8665,9345,9341,6727
0394,2309,9371,9343,8240,8149,2140,4515,7396,7356";

            string values = raw.Replace(",", "").Replace("\r\n", "");

            dataGridView1.DataSource = Operations.GetNumbersOnly(values);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = (List<Item>)dataGridView1.DataSource;

            foreach (var item in items)
            {
                var (character, count) = item;
                Console.WriteLine($"{count, -6}{character}");
            }

        }

        private void CountNumbersButton_Click(object sender, EventArgs e)
        {
            var values = "81,0,88,82,7,18,12,82,7,88,0".Split(',');
            var result = Operations.GetAllNumbers(values.ToIntegerArray());
            dataGridView1.DataSource = result;

            var specificFind = result.FirstOrDefault(numberItem => numberItem.Item == 82);
            if (specificFind != null)
            {
                MessageBox.Show($"{specificFind.Occurrences}");
            }
        }
    }
}
