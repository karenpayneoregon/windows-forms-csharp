using System;
using System.Collections.Generic;
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
    }
}


