using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer
{
    /// <summary>
    /// https://stackoverflow.com/questions/30462079/run-async-method-regularly-with-specified-interval
    /// </summary>
    public partial class Form1 : Form
    {
        Timer _serviceTimer;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            InitTimer();
        }
        private void InitTimer()
        {
            _serviceTimer = new Timer(Dispatcher);
            _serviceTimer.Change(TimeSpan.FromMinutes(5).Seconds, Timeout.Infinite);
        }

        private void Dispatcher(object e)
        {
            UpdateSomething();
            _serviceTimer.Dispose();
            InitTimer();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _serviceTimer.Dispose();
            // the following will throw an exception
            _serviceTimer.Change(TimeSpan.FromMinutes(5).Seconds, Timeout.Infinite);
        }


        private void UpdateSomething()
        {
            // do work
        }

        public async Task PeriodicFooAsync(TimeSpan interval, CancellationToken cancellationToken)
        {
            while (true)
            {
                await FooAsync();
                await Task.Delay(interval, cancellationToken);
            }
        }
        public async Task StartTimer(CancellationToken cancellationToken)
        {

            await Task.Run(async () =>
            {
                while (true)
                {
                    if (checkBox1.Checked)
                    {
                        await WorkerTask();
                    }
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    await Task.Delay(1000, cancellationToken);
                    Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                    
                }
            }, cancellationToken);

        }

        public async Task WorkerTask()
        {
            Console.WriteLine(nameof(WorkerTask));
            await Task.Delay(2000);
        }

        private async Task FooAsync()
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            await StartTimer(_cancellationTokenSource.Token);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel(false);
        }
    }
}
