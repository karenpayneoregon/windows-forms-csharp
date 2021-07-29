using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Title = "Demos";
            
            static Task<string> Simple() => Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    return $"Hello from {nameof(Simple)}";
                });


            Console.WriteLine("String example");
            Console.WriteLine(await Simple());

            Console.WriteLine();
            Console.WriteLine("Iterator example");
            
            await DemoAsync();

            Console.ReadKey();
        }

        static async Task DemoAsync()
        {
            CancellationTokenSource cancellationSource = new();
            await foreach (var item in 10.RangeAsync(11,20, cancellationToken: cancellationSource.Token).WithCancellation(cancellationSource.Token))
            {
                Console.WriteLine(item);
            };
        }
    }
}
