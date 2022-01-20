using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsDemo
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        private string _fileName = "lastNames.txt";
        public Form1()
        {
            InitializeComponent();

            _bindingSource.DataSource = File.ReadAllLines(_fileName).Select(data => new Data() { Line = data }).ToList();
            listBox1.DataSource = _bindingSource;
            bindingNavigator1.BindingSource = _bindingSource;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = ((List<Data>)_bindingSource.DataSource).Select(data => data.Line).ToArray();
            File.WriteAllLines(_fileName, result);
        }
    }

    public class Data
    {
        public string Line { get; set; }
        public override string ToString() => Line;

    }
}
