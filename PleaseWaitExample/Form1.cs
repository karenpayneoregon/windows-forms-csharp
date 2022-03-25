using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleaseWaitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private async void DoSomeWorkButton_Click(object sender, EventArgs e)
        {
            DoSomeWorkButton.Enabled = false;
            try
            {
                var busyForm = new BusyForm();

                busyForm.Show();

                // for real, replace with work to be done
                for (int index = 0; index < 20; index++)
                {
                    busyForm.OnUpdateText(index);
                    await Task.Delay(250);
                }

                busyForm.Dispose();
            }
            finally
            {
                DoSomeWorkButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}
