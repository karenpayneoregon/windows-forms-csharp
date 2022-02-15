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
using SpreadsheetLightDataGridViewExport.Classes;

namespace SpreadsheetLightDataGridViewExport
{
    public partial class CreateFileWithSheets : Form
    {
        public CreateFileWithSheets()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string fileName = "Months.xlsx";
            
            List<string> sheetNameList = Enumerable.Range(1, 12).
                Select((index) => DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();

            Dictionary<string, string> headerDictionary = new Dictionary<string, string>()
            {
                {"A1","Qty" },
                {"B1","Description" },
                {"C1","S/N" },
                {"D1","P/N" },
                {"E1","Model" },
                {"F1","Category" },
                {"G1","Type" },
                {"H1","Status" },
                {"I1","Notes" }
            };
            
            var (success, exception) = ExcelHelpers.CreateWithSheets(fileName, sheetNameList, headerDictionary);
            MessageBox.Show(success ? "Done" : exception.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpreadSheetLightSearchOperations.ConvertCasing("demo1.xlsx", "sheet1", 1);
            MessageBox.Show("Test");
        }
    }
}
