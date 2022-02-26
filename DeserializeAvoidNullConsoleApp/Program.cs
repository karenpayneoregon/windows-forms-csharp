using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DeserializeAvoidNullConsoleApp.Classes;
using DeserializeAvoidNullConsoleApp.Converters;
using DeserializeAvoidNullConsoleApp.Models;

namespace DeserializeAvoidNullConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "";
            FileOperations.Write();

            var list = FileOperations.Read();

            foreach (var data in list)
            {
                Console.WriteLine($"{data.Id, -6:D3}{data.FirstName, -10}{data.LastName,-10}{data.Country, -10} Country is null: {(data.Country is null)}");
            }

            Console.WriteLine();

            foreach (var data in list)
            {
                Console.WriteLine($"{data.Id,-6:D3}{data.FirstName,-10}{data.LastName,-10}{data.Country,-10} First name is null: {(data.FirstName is null)}");
            }

            Console.ReadLine();
        }
    }
}
