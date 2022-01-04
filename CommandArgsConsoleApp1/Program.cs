// @nuget: CommandLineParser -Version 2.8.0

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.Extensions.Configuration;

namespace CommandArgsConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var switchMappings = new Dictionary<string, string>()
            {
                { "-k1", "key1" },
                { "-k2", "key2" }
            };
            var builder = new ConfigurationBuilder();
            builder.AddCommandLine(args, switchMappings);

            var config = builder.Build();

            Debug.WriteLine($"Key1: '{config["Key1"]}'");
            Debug.WriteLine($"Key2: '{config["Key2"]}'");
        }

  



    }

    
}