using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        private string basilacakharf; // not my doing
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


            foreach (var c in alphabet)
            {
                _dictionary.Add(c.ToString(), c.ToString().ToLower());
            }

            var source = alphabet.ToList();
            comboBox1.DataSource = source;
            comboBox2.DataSource = new List<char>(source);
            
            comboBox1.SelectedIndexChanged += ComboBox1OnSelectedIndexChanged;


            Dictionary<string, string> dictionary1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                .ToCharArray()
                .ToList()
                .ToDictionary(item => item.ToString(), item => item.ToString().ToLower());

            var dictionary = alphabet.Select((value, index) => new { value, index })
                .ToDictionary(pair => pair.value, pair => pair.index);

        }

        
        private void ComboBox1OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // same needed for second comboBox
            basilacakharf = _dictionary[comboBox1.Text];
            Text = $"comboBox1 {basilacakharf}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string countryName = RegionInfo.CurrentRegion.DisplayName;
            var regionName = RegionInfo.CurrentRegion.ThreeLetterWindowsRegionName;
            Console.WriteLine($"{countryName}, {regionName}");
        }
    }
}
