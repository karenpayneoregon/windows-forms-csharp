using System;
using System.IO;
using System.Windows.Forms;
using ExcelInteropApp.Classes;

namespace ExcelInteropApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateExcelButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ExcelOperations.ActionHandler += ExcelOperationsOnActionHandler;
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Demo.xlsx");
            string firstSheet = "Karen";
            string secondSheet = "Karen 1";
            
            var (success, exception) = ExcelOperations.CreateExcelFile(fileName,firstSheet, secondSheet, openWhenDoneCheckBox.Checked);
            if (success == false)
            {
                Console.WriteLine(exception.Message);
            }

            ExcelOperations.ActionHandler -= ExcelOperationsOnActionHandler;

        }

        private void ExcelOperationsOnActionHandler(string sender)
        {
            listBox1.Items.Add(sender);
        }

    }
}
