using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithTimer.Classes;
using WorkingWithTimer.LanguageExtensions;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer
{
    /// <summary>
    /// https://stackoverflow.com/questions/30462079/run-async-method-regularly-with-specified-interval
    /// </summary>
    public partial class Form1 : Form
    {
        private int _wait = 6000 * 10;
        Timer _serviceTimer;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        
        public Form1()
        {
            InitializeComponent();


            TimerHelper.Message += OnMessageReceived;
        }

        private void OnMessageReceived(string message) 
            => listBox1.InvokeIfRequired(lb => lb.Items.Add(message));
        
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
            _serviceTimer.Change(_wait, Timeout.Infinite);
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

            try
            {
                _serviceTimer.Change(_wait, Timeout.Infinite);
            }
            catch (ObjectDisposedException ex)
            {
            }
        }


        private void UpdateSomething()
        {
            Console.WriteLine("Do work");
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
            await Task.Delay(0);
            // TODO
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

        private void UtilsStartButton_Click(object sender, EventArgs e)
        {
            TimerHelper.Start(FormWork);
        }

        private void UtilsStopButton_Click(object sender, EventArgs e)
        {
            TimerHelper.Stop();
        }

        public void FormWork()
        {
            /*
             * Place code here e.g.
             *
             * this.Hide();
             * Form1 main = new Form1();
             * main.Show();
             * 
             */
            TimerHelper.Stop();
            Console.WriteLine("Worked");

        }
    }
}
