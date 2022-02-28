using System;
using System.Threading;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer.Classes
{
    public class TimerHelper
    {
        /// <summary>
        /// How long between intervals, currently 30 minutes
        /// </summary>
        private static int _dueTime = 1000 * 60 * 30;
        private static Timer _workTimer;
        public static ActionContainer ActionContainer;

        /// <summary>
        /// Text to display to listener 
        /// </summary>
        /// <param name="message">text</param>
        public delegate void MessageHandler(string message);
        /// <summary>
        /// Optional event 
        /// </summary>
        public static event MessageHandler Message;
        /// <summary>
        /// Flag to determine if timer should initialize 
        /// </summary>
        public static bool ShouldRun { get; set; } = true;

        /// <summary>
        /// Default initializer
        /// </summary>
        private static void Initialize()
        {
            if (!ShouldRun) return;
            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }

        /// <summary>
        /// Initialize with time to delay before triggering <see cref="Worker"/>
        /// </summary>
        /// <param name="dueTime"></param>
        private static void Initialize(int dueTime)
        {
            if (!ShouldRun) return;
            _dueTime = dueTime;
            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }
        /// <summary>
        /// Trigger work, restart timer
        /// </summary>
        /// <param name="e"></param>
        private static void Dispatcher(object e)
        {
            Worker();
            _workTimer.Dispose();
            Initialize();
        }

        /// <summary>
        /// Start timer without an <see cref="Action"/>
        /// </summary>
        public static void Start()
        {
            Initialize();
            Message?.Invoke("Started");
        }
        /// <summary>
        /// Start timer with an <see cref="Action"/>
        /// </summary>
        public static void Start(Action action)
        {
            ActionContainer = new ActionContainer();
            ActionContainer.Action += action;
            
            Initialize();

            Message?.Invoke("Started");

        }
        /// <summary>
        /// Stop timer
        /// </summary>
        public static void Stop()
        {
            _workTimer.Dispose();
            Message?.Invoke("Stopped");
        }

        /// <summary>
        /// If <see cref="ActionContainer"/> is not null trigger action
        /// else alter listeners it's time to perform work in caller
        /// </summary>
        private static void Worker()
        {
            Message?.Invoke("Performing work");
            ActionContainer?.Action();
        }
    }
}
