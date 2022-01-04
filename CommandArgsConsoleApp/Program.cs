using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CommandArgsConsoleApp.Classes;
using CommandLine;
using CommandLine.Text;


namespace CommandArgsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CommandLineHelp.ParseArguments("--help".Split());
            CommandLineHelp.ParseArguments(args);
            
        }
    }
}
