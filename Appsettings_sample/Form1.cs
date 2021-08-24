using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appsettings_sample.Classes;

namespace Appsettings_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show connection string stored in appsettings.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetConnectionStringButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helper.ConnectionString());
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            var (success, exception) = SqlOperations.TestConnection();
            MessageBox.Show(success ? @"Open connection successful" : $"Failed to open connection\n{exception.Message}");
        }

        private void BuildDateButton_Click(object sender, EventArgs e)
        {
            DateTime buildDate = GetBuildDate(Assembly.GetExecutingAssembly());

        }
        private static DateTime GetBuildDate(Assembly assembly)
        {
            var attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
            return attribute?.DateTime ?? default(DateTime);
        }
    }
}
