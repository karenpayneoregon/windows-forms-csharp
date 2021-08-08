using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AsyncSimple.Classes;
using static AsyncSimple.Classes.GlobalStuff;

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

            Console.ReadLine();
        }

        public static async Task<bool> Example1()
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(1);
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


