using System;
using SqlServerUtilityLibrary.Classes;

namespace SqlServerUtilityLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BlogOperations.RestoreBlogDatabase() ? "Yes" : "No");
            Console.ReadLine();
        }
    }
}
