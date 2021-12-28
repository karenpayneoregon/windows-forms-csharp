using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDatesInFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<DateTime> results1 = File
                .ReadAllLines("dates.txt")
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => DateTime.ParseExact(line, "dd/MM/yyyy HH:mm:ss", 
                    CultureInfo.InvariantCulture)).ToList();

            List<DateTime> results2 = File
                .ReadAllLines("dates1.txt")
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => DateTime.ParseExact(line, "dd/MM/yyyy HH:mm:ss", 
                    CultureInfo.InvariantCulture))
                .ToList();


            List<DateTime> duplicates = results1.Intersect(results2).ToList();

            if (duplicates.Any())
            {
                foreach (var duplicate in duplicates)
                {
                    Debug.WriteLine(duplicate);
                }
            }

            Debug.WriteLine("");

            List<DateTime> except = results1.Except(results2).ToList();

            foreach (var dateTime in except)
            {
                Debug.WriteLine(dateTime);
            }

            Debug.WriteLine("");

            foreach (var dateTime in results1)
            {
                if (results2.Contains(dateTime))
                {
                    Debug.WriteLine($"{dateTime} is a dup");
                }
                else
                {
                    Debug.WriteLine($"{dateTime} is not a dup");
                }
            }
        }
    }
}


