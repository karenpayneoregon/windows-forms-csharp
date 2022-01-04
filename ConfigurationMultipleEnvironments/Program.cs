using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using ConfigurationMultipleEnvironments.Classes;
using Microsoft.Extensions.Configuration;

namespace ConfigurationMultipleEnvironments
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // for demonstration purposes
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

            Console.Title = "Connection strings from json or environment var";

            Debug.WriteLine($"Env: {ConfigurationHelper.GetConnectionStringFromEnvironment()}");
            Debug.WriteLine($"{ConfigurationHelper.CurrentEnvironment}");
            
            Debug.WriteLine("");

            Debug.WriteLine($"Json: {ConfigurationHelper.GetConnectionStringFromJson()}");
            Debug.WriteLine($"{ConfigurationHelper.CurrentEnvironment}");
        }
    }
}
