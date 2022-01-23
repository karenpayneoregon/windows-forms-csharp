using System.Threading;
using Timer = System.Threading.Timer;

namespace WorkingWithTimer.Classes
{
    public class Utilities
    {
        private static int _dueTime = 6000 * 10;
        private static Timer _serviceTimer;

        public delegate void MessageHandler(string message);
        public static event MessageHandler Message;

        private static void Initialize()
        {
            _serviceTimer = new Timer(Dispatcher);
            _serviceTimer.Change(_dueTime, Timeout.Infinite);
        }

        private static void Initialize(int dueTime)
        {
            _dueTime = dueTime;
            _serviceTimer = new Timer(Dispatcher);
            _serviceTimer.Change(_dueTime, Timeout.Infinite);
        }
        private static void Dispatcher(object e)
        {
            StatusCheck();
            _serviceTimer.Dispose();
            Initialize();
        }

        public static void Start()
        {
            Initialize();
            Message?.Invoke("Started");

        }
        public static void Stop()
        {
            _serviceTimer.Dispose();
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
