using System.Threading;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer.Classes
{
    public class Utilities
    {
        /// <summary>
        /// How long between intervals, adjust as needed or use Initialize overload
        /// </summary>
        private static int _dueTime = 6000 * 10;
        private static Timer _workTimer;

        public delegate void MessageHandler(string message);
        /// <summary>
        /// Optional event
        /// </summary>
        public static event MessageHandler Message;
        /// <summary>
        /// Flag to determine if timer should initialize 
        /// </summary>
        public static bool ShouldRun { get; set; } = true;

        private static void Initialize()
        {
            if (!ShouldRun) return;

            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }

        private static void Initialize(int dueTime)
        {
            if (!ShouldRun) return;
            _dueTime = dueTime;
            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }
        private static void Dispatcher(object e)
        {
            Worker();
            _workTimer.Dispose();
            Initialize();
        }

        public static void Start()
        {
            Initialize();
            Message?.Invoke("Started");
        }
        public static void Stop()
        {
            _workTimer.Dispose();
            Message?.Invoke("Stopped");
        }

        /// <summary>
        /// Where work is done
        /// </summary>
        private static void Worker()
        {
            Message?.Invoke("Performing work");
        }

    }
}
