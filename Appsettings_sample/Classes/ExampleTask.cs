using System.Diagnostics;
using System.Threading.Tasks;

namespace Appsettings_sample.Classes
{
    public class ExampleTask
    {
        public delegate void OnProcess(string sender);
        public static event OnProcess ProcessHandler;
        public static Task FirstAsync()
        {
            ProcessHandler?.Invoke($"Started {nameof(FirstAsync)}");

            return Task.Delay(1000).ContinueWith(t =>
                ProcessHandler?.Invoke($"Finished  {nameof(FirstAsync)}"));
        }

        public static Task SecondAsync()
        {
            ProcessHandler?.Invoke($"Started {nameof(SecondAsync)}");
            return Task.Delay(1000).ContinueWith(t =>
                ProcessHandler?.Invoke($"Finished  {nameof(SecondAsync)}"));
        }
        public static Task ThirdAsync()
        {
            ProcessHandler?.Invoke($"Started {nameof(ThirdAsync)}");
            return Task.Delay(1000).ContinueWith(t =>
                ProcessHandler?.Invoke($"Finished  {nameof(ThirdAsync)}"));
        }

    }
}
