using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BenTamConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;
            Console.WriteLine("Always false");
            RunTests(size, x => false);

            Console.WriteLine("Always true");
            RunTests(size, x => true);
        }
        static void RunTests(int size, Func<string, bool> predicate)
        {
            for (int i = 1; i <= 10; i++)
            {
                RunTest(i, size, predicate);
            }
        }

        static void RunTest(int depth, int size, Func<string, bool> predicate)
        {
            IEnumerable<string> input = Enumerable.Repeat("value", size);

            for (int i = 0; i < depth; i++)
            {
                input = input.Where(predicate);
            }

            Stopwatch sw = Stopwatch.StartNew();
            input.Count();
            sw.Stop();
            Console.WriteLine("Depth: {0} Size: {1} Time: {2}ms",
                depth, size, sw.ElapsedMilliseconds);
        }
    }
}
