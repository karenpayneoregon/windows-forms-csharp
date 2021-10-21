using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "";
        }
        private async Task AsyncMethod(IProgress<int> progress, CancellationToken ct)
        {

            for (int index = 100; index <= 120; index++)
            {
                //Simulate an async call that takes some time to complete
                await Task.Delay(200);

                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }

                if (progress != null)
                {
                    progress.Report(index);
                }

            }

        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            var cancelled = false;
            if (_cts.IsCancellationRequested == true)
            {
                _cts.Dispose();
                _cts = new CancellationTokenSource();
            }


            var progressIndicator = new Progress<int>(ReportProgress);
            try
            {
                await AsyncMethod(progressIndicator, _cts.Token);
            }
            catch (OperationCanceledException ex)
            {
                StatusLabel.Text = "Cancelled";
                cancelled = true;
            }

            if (cancelled)
            {
                await Task.Delay(1000);
                StatusLabel.Text = "Go again!";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
        private void ReportProgress(int value)
        {
            StatusLabel.Text = value.ToString();
            TextBox1.Text = value.ToString();
        }
    }
}
