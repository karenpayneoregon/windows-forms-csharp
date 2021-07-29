using System;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            static Task<string> Simple() => Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    return $"Hello from {nameof(Simple)}";
                });


            Console.WriteLine(await Simple());

            Console.ReadKey();
        }
    }
}
