using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDefaultValueDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateReadFileButton_Click(object sender, EventArgs e)
        {
            Mocked.Populate();
            Reports reports = Mocked.Load();
            
            Console.WriteLine("DWDD004");
            var firstReport = reports.List.FirstOrDefault(x => x.Name == "DWDD004");
            Console.WriteLine(firstReport.Database == "empty" ? "No database name" : firstReport.Database);

            Console.WriteLine();

            Console.WriteLine("DWDD007");
            var secondReport = reports.List.FirstOrDefault(x => x.Name == "DWDD007");
            Console.WriteLine(secondReport.Database == "empty" ? "No database name" : secondReport.Database);
        }
    }
}
