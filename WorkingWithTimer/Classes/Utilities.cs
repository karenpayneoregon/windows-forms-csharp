using System.Threading;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer.Classes
{
    public class Utilities
    {
        private static int _dueTime = 6000 * 10;
        private static Timer _workTimer;

        public delegate void MessageHandler(string message);
        public static event MessageHandler Message;

        private static void Initialize()
        {
            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }

        private static void Initialize(int dueTime)
        {
            _dueTime = dueTime;
            _workTimer = new Timer(Dispatcher);
            _workTimer.Change(_dueTime, Timeout.Infinite);
        }
        private static void Dispatcher(object e)
        {
            StatusCheck();
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
        /// Report to caller status e.g.
        /// Globals.sSSIS_TDMAT_STATUS = "Success";
        /// </summary>
        private static void StatusCheck()
        {
            Message?.Invoke("Performing work");
        }

    }
}
