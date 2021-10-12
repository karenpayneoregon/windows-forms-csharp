using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonDemo.Classes;

namespace SingletonDemo
{
    public partial class SingletonForm : Form
    {
        public SingletonForm()
        {

            InitializeComponent();

            Text = "Singleton demo";
            ApplicationJobs.ValueChanged += ApplicationSettingsOnValueChanged;
            ApplicationJobs.Instance.IncrementValue();

        }

        private void ApplicationSettingsOnValueChanged(int value)
        {
            textBox1.Text = ApplicationJobs.Instance.Value.ToString();
        }

        private void ExecuteButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.Work();
        }

        private void IncrementButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.IncrementValue(2);
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.Reset();
        }
    }
}
