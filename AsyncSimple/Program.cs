using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AsyncSimple.Classes;
using static AsyncSimple.Classes.GlobalStuff;
using TimeSpan = System.TimeSpan;

namespace AsyncSimple
{
    class Program
    {
        private static readonly CancellationTokenSource _cancellationSource = new();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Return bool");
            var example1Result = await Example1();
            Console.WriteLine($"\t{example1Result.ToYesNo()}");

            Console.WriteLine();
            Console.WriteLine("Return list");
            
            var customersList = await Example2();

            foreach (var customer in customersList)
            {
                Console.WriteLine($"\t{customer}");
            }

            Console.WriteLine();
            Console.WriteLine("Iterator");
            await Example3();


            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(20);

            Console.WriteLine();
            Console.WriteLine("Last example");
            var timer = new Timer(async (e) =>
            {
                var x = await Example1();

                Console.WriteLine(x.ToYesNo());
                
            }, null, startTimeSpan, periodTimeSpan);

            
            Console.WriteLine("Done"); // shown prior to timer completion

            await Example4();


            
            Console.ReadLine();
        }

        public static async Task<bool> Example1()
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(1000);
                return true;
            });

        }

        public static async Task<List<Customers>> Example2()
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(1);
                return MockedData.MockedInMemoryCustomers();
            });

        }

        private static async Task Example3()
        {
            try
            {
                await foreach (var item in 10.RangeAsync(MaxNumber, _cancellationSource.Token).WithCancellation(_cancellationSource.Token))
                {
                    Console.WriteLine($"\t{item}");
                }

                ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async Task Example4()
        {
            // this task will take about 2.5s to complete
            var sumTask = SlowAndComplexSumAsync();

            // this task will take about 4s to complete
            var wordTask = SlowAndComplexWordAsync();

            // running them in parallel should take about 4s to complete
            await Task.WhenAll(sumTask, wordTask);
            
            Console.WriteLine("Result of complex sum = " + sumTask.Result);
            Console.WriteLine("Result of complex letter processing " + wordTask.Result);
        }
        

        private static async Task<int> SlowAndComplexSumAsync()
        {
            int sum = 0;
            foreach (var counter in Enumerable.Range(0, 25))
            {
                sum += counter;
                await Task.Delay(100);
            }

            return sum;
        }
        private static async Task<string> SlowAndComplexWordAsync()
        {
            var word = string.Empty;
            foreach (var counter in Enumerable.Range(65, 26))
            {
                word = string.Concat(word, (char)counter);
                await Task.Delay(150);
            }

            return word;
        }
    }
}


