using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EveryMinuteSharp.Classes;
using EveryMinuteSharp.Extensions;

namespace EveryMinuteSharp
{
    public partial class Form1 : Form
    {
        private readonly CountDownTimer _countDownTimer = new ();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            var seconds = 60;
            _countDownTimer.SetTime(0, seconds);
            _countDownTimer.Start();
            
            Label1.Text = $"{seconds -1}";
            Label1.Refresh();


            _countDownTimer.TimeChanged = () =>
            {
                Label1.InvokeIfRequired( ( _ ) => Label1.Text = _countDownTimer.TimeLeftMinutesSeconds);
            };

            _countDownTimer.CountDownFinished = () =>
            {
                _countDownTimer.Stop();
                MessageBox.Show("Done");
            };

		}

        private void StopButton_Click(object sender, EventArgs e)
        {
            _countDownTimer.Stop();
        }

    }

}
