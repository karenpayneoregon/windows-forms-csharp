using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appsettings_sample.Classes;

namespace Appsettings_sample
{
    public partial class TaskForm : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new ();

        public TaskForm()
        {
            InitializeComponent();

            ExampleTask.ProcessHandler += OnProcessing;
        }

        private void OnProcessing(string sender)
        {
            listBox1.InvokeIfRequired(lb => { lb.Items.Add(sender);});
        }

        private void SeveralTaskButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<Func<Task>> list = new List<Func<Task>>
            {
                ExampleTask.FirstAsync,
                ExampleTask.SecondAsync,
                ExampleTask.ThirdAsync
            };

            Task taskingAsync = TaskHelpers.ForEachAsync(list);

            taskingAsync.ContinueWith(task => 
                    Debug.WriteLine(task.Exception.ToString()),
                TaskContinuationOptions.OnlyOnFaulted);

            taskingAsync.ContinueWith(task =>
                    Debug.WriteLine("Done!"),
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        private async void AsyncLazyButton_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var siteAddress = "https://stackoverflow.com";

            var deferredTask = new AsyncLazy<string>(async () 
                => await httpClient.GetStringAsync(siteAddress));

            var websiteSource = await deferredTask;
            Debug.WriteLine(websiteSource);
            MessageBox.Show("See Output window");

        }
        private async Task SomeOperation(CancellationToken ct, int upperValue)
        {
            for (int index = 0; index < upperValue; index++)
            {
                listBox1.Items.Add($"Index: {index + 1} Sleep for 2 seconds.");
                progressBar1.Increment(10);
                await Task.Delay(2000, ct);
            }

            listBox1.Items.Add("Done");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();

            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Add("Cancelled");
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 0;

            await Task.Delay(500);

            var cancelled = false;

            if (_cancellationTokenSource.IsCancellationRequested == true)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            /*
             * Set time-out for seven seconds
             */
            int timeout = 7000;

            var task = SomeOperation(_cancellationTokenSource.Token, 10);

            try
            {
                if (await Task.WhenAny(task, Task.Delay(timeout, _cancellationTokenSource.Token)) == task)
                {
                    // Task completed within timeout.
                    // Consider that the task may have faulted or been canceled.
                    // We re-await the task so that any exceptions/cancellation is rethrown.
                    await task;

                }
                else
                {
                    // timeout/cancellation logic
                }
            }
            catch
            {
                cancelled = true;
            }

        }
    }
}
