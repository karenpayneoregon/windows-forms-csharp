using System.Diagnostics;
using System.Threading.Tasks;

namespace Appsettings_sample.Classes
{
    public class ExampleTask
    {
        public static Task FirstAsync()
        {
            Debug.WriteLine($"Started {nameof(FirstAsync)}");
            return Task.Delay(1000).ContinueWith(t =>
                Debug.WriteLine($"Finished  {nameof(FirstAsync)}"));
        }

        public static Task SecondAsync()
        {
            Debug.WriteLine($"Started {nameof(SecondAsync)}");
            return Task.Delay(1000).ContinueWith(t =>
                Debug.WriteLine($"Finished {nameof(SecondAsync)}"));
        }
        public static Task ThirdAsync()
        {
            Debug.WriteLine($"Started {nameof(ThirdAsync)}");
            return Task.Delay(1000).ContinueWith(t =>
                Debug.WriteLine($"Finished {nameof(ThirdAsync)}"));
        }

    }
}
