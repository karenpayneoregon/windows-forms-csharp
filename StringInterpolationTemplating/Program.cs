using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StringInterpolationTemplating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Templating";
            var template1 = new Template1("Karen", new DateTime(1956, 9, 24));

            Debug.WriteLine("");
            Debug.WriteLine(template1);
            Debug.WriteLine("");
        }
    }

    public class Template1
    {
        private const string Template = @"Her name is {name} and her birthday is on {dob}, which is in {month} for {name}.";
        private readonly Dictionary<string, string> _parameters = new();

        public Template1(string name, DateTime dob)
        {
            // validate parameters before assignments

            _parameters.Add(@"{name}", name);
            _parameters.Add(@"{dob}", $"{dob:MM/dd/yyyy}");
            _parameters.Add(@"{month}", $"{dob:MMMM}");
        }

        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
            => _parameters.Aggregate(Template, (sender, kvp) 
                => sender.Replace(kvp.Key, kvp.Value));
    }
}
