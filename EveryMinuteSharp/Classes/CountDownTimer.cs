using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace EveryMinuteSharp.Classes
{
    /// <summary>
    /// Provides methods to perform a visual countdown timer
    /// </summary>
    public class CountDownTimer : IDisposable
    {
        public Stopwatch StopWatch = new();

        public Action TimeChanged;
        public Action CountDownFinished;

        /// <summary>
        /// Is Timer enabled
        /// </summary>
        public bool IsRunning => timer.Enabled;

        public int StepMs
        {
            get => (int) timer.Interval;
            set => timer.Interval = value;
        }

        private readonly Timer timer = new();

        private TimeSpan _max = TimeSpan.FromMilliseconds(30000);

        public TimeSpan TimeLeft => (_max.TotalMilliseconds - StopWatch.ElapsedMilliseconds) > 0 ? 
            TimeSpan.FromMilliseconds(_max.TotalMilliseconds - StopWatch.ElapsedMilliseconds) : 
            TimeSpan.FromMilliseconds(0);

        private bool _mustStop => (_max.TotalMilliseconds - StopWatch.ElapsedMilliseconds) < 0;
        
        /// <summary>
        /// Time left in minutes, seconds
        /// </summary>
        public string TimeLeftMinutesSeconds => TimeLeft.ToString(@"ss");
        
        /// <summary>
        /// Time left in minutes, seconds, milliseconds
        /// </summary>
        public string TimeLeftMinutesSecondsMilliseconds => TimeLeft.ToString(@"mm\:ss\.fff");
        
        private void TimerTick(object sender, EventArgs e)
        {
            TimeChanged?.Invoke();

            if (!_mustStop) return;
            
            CountDownFinished?.Invoke();
            StopWatch.Stop();
            timer.Enabled = false;
            
        }

        public CountDownTimer(int min, int sec)
        {
            SetTime(min, sec);
            Initialize();
        }

        public CountDownTimer(TimeSpan ts)
        {
            SetTime(ts);
            Initialize();
        }

        public CountDownTimer()
        {
            Initialize();
        }

        private void Initialize()
        {
            StepMs = 1000;
            timer.Elapsed += TimerTick;
        }

        public void SetTime(TimeSpan ts)
        {
            _max = ts;
            TimeChanged?.Invoke();
        }

        public void SetTime(int min, int sec = 0) => SetTime(TimeSpan.FromSeconds(min * 60 + sec));

        public void Start()
        {
            timer.Start();
            StopWatch.Start();
        }

        public void Pause()
        {
            timer.Stop();
            StopWatch.Stop();
        }

        public void Stop()
        {
            Reset();
            Pause();
        }

        public void Reset()
        {
            StopWatch.Reset();
        }

        public void Restart()
        {
            StopWatch.Reset();
            timer.Start();
        }

        public void Dispose() => timer.Dispose();
    }
}
