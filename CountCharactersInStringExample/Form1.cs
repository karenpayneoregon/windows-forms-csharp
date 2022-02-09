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

        private void button2_Click(object sender, EventArgs e)
        {

            string[] lines = {
                "8182,2114,9871,3335,5653,1812,5503,5310,9234,8864,0841,6947,0275,5765,0869,5877,0160,5120,0107,3023,8970,6360,4241",
                "0251,1292,8111,7166,6149,5676,6301,5207,3242,2205,0765,9177,9988,4080,6972,5337,9173,4805,4720,8152,8805,5028,8625"
            };

            lines.AllInt();
            Dictionary<int, List<Item>> dictionary = new Dictionary<int, List<Item>>();
            for (int index = 0; index < lines.Length; index++)
            {
                dictionary.Add(index, Operations.GetNumbersOnly(lines[index]));
            }
        }
    }
}
