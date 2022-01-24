using System.Threading;
using System.Threading.Tasks;
using Timer = System.Threading.Timer;

namespace HelpersUtilitiesProject.Classes
{
    class TimerHelper
    {
        private static int _dueTime = 100 * 10;
        private static Timer _workTimer;

        public delegate void MessageHandler(string message);
        public static event MessageHandler Message;

        private static void Initialize()
        {
            var workTimer = new Timer(Dispatcher);
            workTimer.Change(_dueTime, Timeout.Infinite);
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
            Initialize();
        }

        public static void Start()
        {
            Initialize();
        }
        public static void Stop()
        {
            _workTimer.Dispose();
        }
        private static void StatusCheck()
        {
            var result = Task.Run(Utilities.IsConnectedToInternetAsync).Result;
            Message?.Invoke(result ? "Internet is available" : "Internet is not available");
        }

    }
}
