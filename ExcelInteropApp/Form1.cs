using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        private async void CreateExcelButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ExcelOperations.ActionHandler += OnActionHandler;

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Demo.xlsx");

            string firstSheet = "Karen";
            string secondSheet = "Karen 1";

            await Task.Run(async () =>
            {
                await Task.Delay(1);
                var (success, exception) = ExcelOperations.CreateExcelFile(fileName, firstSheet, secondSheet);
                if (success == false)
                {
                    Console.WriteLine(exception.Message);
                }
                else
                {
                    listBox1.InvokeIfRequired(lb => lb.Items.Add("Done"));
                }
            });


            ExcelOperations.ActionHandler -= OnActionHandler;

        }

        private void OnActionHandler(string sender)
        {
            listBox1.InvokeIfRequired( lb => lb.Items.Add(sender));
        }

        private void ExcelVersionButton_Click(object sender, EventArgs e)
        {
            Version version = new Version(ExcelOperations.ExcelVersion());
            MessageBox.Show($"{version.Major}.{version.Minor}");
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"In memory: {(Process.GetProcesses().Any((p) => p.ProcessName.Contains("EXCEL")) ? "No" : "Yes")}");
        }
    }
}
