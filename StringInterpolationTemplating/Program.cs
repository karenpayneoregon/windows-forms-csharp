using System;
using System.Diagnostics;
using StringInterpolationTemplating.Classes;


namespace StringInterpolationTemplating
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(Native("Karen", DateTime.Now));
            Debug.WriteLine(Native("Bob", new DateTime(1945, 11, 1)));
            

        }


        private static string Native(string name, DateTime dob)
        {
            return new NativeTemplate(name, dob).ToString();
        }
    }
}
