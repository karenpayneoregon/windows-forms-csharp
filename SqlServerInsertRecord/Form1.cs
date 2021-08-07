using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerInsertRecord.Classes;
using SqlServerInsertRecord.Models;

namespace SqlServerInsertRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee() {FirstName = "Karen", LastName = "Payne", HiredDate = DateTime.Now};

            /*
             * If needed use exception returned from 
             */
            var (success, exception) = Operations.Insert(employee);
            label1.Text = success ? $"New id: {employee.Id}" : "Failed";
        }
    }
}
