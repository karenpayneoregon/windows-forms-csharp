using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SpreadsheetLightDataGridViewExport.Classes;

namespace SpreadsheetLightDataGridViewExport
{
    public partial class PoliciesForm : Form
    {
        public PoliciesForm()
        {
            InitializeComponent();
        }

        private void PoliciesForm_Load(object sender, EventArgs e)
        {
            PoliciesListBox.DataSource = Enumerable.Range(1, 6).Select(x => $"OLD0{x}").ToList();
        }

        private void FindDuplicatesButton_Click(object sender, EventArgs e)
        {
            ResultsListBox.Items.Clear();
            
            var policy = PoliciesListBox.Text;
            //ExcelOperations

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FindDups.xlsx");
            var sheetName = "Polices";

            /*
             * pass in file name, text to find and the column index, in this case A column
             */
            var (items, exception) = SpreadSheetLightOperations
                .FindDuplicates(fileName, sheetName, policy, 1);
            
            if (exception != null)
            {
                MessageBox.Show($"Error\n{exception.Message}");
            }
            else
            {
                if (items.Count >1)
                {
                    foreach (var item in items)
                    {
                        ResultsListBox.Items.Add(item.ToString());
                    }
                }
                else
                {
                    MessageBox.Show($"No rows found for {PoliciesListBox.Text}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FindDups.xlsx");
            var sheetName = "SearchFor";

            var (items, exception) = SpreadSheetLightSearchOperations.Find(fileName, sheetName, "OLD04");
            if (exception is null)
            {
                foreach (var foundItem in items)
                {
                    Debug.WriteLine(foundItem);
                }
            }
            else
            {
                Debug.WriteLine(exception.Message);
            }

        }
    }
}
