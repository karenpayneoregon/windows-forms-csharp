using System;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            Console.Title = "async Task<int> Main";
            int number1 = 5, number2 = 10;
            Console.WriteLine($"Sum of {number1} and {number2} is: {await AdditionAsync(number1, number2)}");

            Console.WriteLine(await Simple());
            
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
            return 0;
        }
        private static Task<int> AdditionAsync(int value1, int value2)
        {
            return Task.Run(() => SumIt(value1, value2));

            int SumIt(int x, int y)
            {
                return x + y;
            }
        }

        private static Task<string> Simple() => Task.Run(() => $"{nameof(Simple)}");
    }
}
