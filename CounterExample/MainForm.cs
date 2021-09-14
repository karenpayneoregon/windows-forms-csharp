using System;
using System.ComponentModel;
using st = System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterExample
{
    public partial class MainForm : Form
    {
        st.Timer _counterTimer;
        
        public int _numberOfSecondsTrigger = 60;
        public int _timesExecutes = 1;
        private int _seconds = 0;
        
        public MainForm()
        {
            InitializeComponent();
            
            Shown += OnShown;
            Closing += OnClosing;
            
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _counterTimer.Dispose();
        }
        

        private void OnShown(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            _counterTimer = new st.Timer(Dispatcher);
            _counterTimer.Change(1, st.Timeout.Infinite);
        }

        private async void Dispatcher(object state)
        {
            _counterTimer.Dispose();
            await RunJob();
            StartTimer();
        }

        private async Task RunJob()
        {
            _seconds++;

            if ( _seconds > _numberOfSecondsTrigger )
            {
                _seconds = 0;
                
                TimesLabel.InvokeIfRequired(label => label.Text = _timesExecutes.ToString());
                
                _timesExecutes += 1;
                
                StartTimer();

            }
           
            lblView.InvokeIfRequired( label => label.Text = TimeSpan.FromSeconds(_seconds).ToString("ss") );
            
            await Task.Delay(1000);
        }
       
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != (Keys.Alt | Keys.F2)) return base.ProcessCmdKey(ref msg, keyData);
            Environment.Exit(0);
            return true;

        }

    }


}
