using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Scriban;
using StringInterpolationTemplating.Classes;


namespace StringInterpolationTemplating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Templating";
            Debug.WriteLine("Scriban example");
            Debug.WriteLine(TemplateScriban.ScribanFromFile());
            Debug.WriteLine("");
            Debug.WriteLine("Native example");
            Debug.WriteLine(new NativeTemplate("Karen", new DateTime(1956, 9, 24)));
            Debug.WriteLine("");
        }

        private static void NativeTemplating()
        {
            NativeTemplate template1 = new NativeTemplate("Karen", new DateTime(1956, 9, 24));
            
            Debug.WriteLine("");
            Debug.WriteLine(template1);
            Debug.WriteLine("");
        }

   
            
    }

    
}
