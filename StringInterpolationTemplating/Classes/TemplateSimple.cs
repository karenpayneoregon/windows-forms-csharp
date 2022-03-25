using System;
using System.Collections.Generic;
using System.Linq;

namespace StringInterpolationTemplating.Classes
{
    public class NativeTemplate
    {
        private const string _Template1 = 
            @"Her name is {name} and her birthday is on {dob}, which is in {month} for {name}.";

        private readonly Dictionary<string, string> _parameters = new();

        public NativeTemplate(string name, DateTime dob)
        {
            _parameters.Add(@"{name}", name);
            _parameters.Add(@"{dob}", $"{dob:MM/dd/yyyy}");
            _parameters.Add(@"{month}", $"{dob:MMMM}");
        }

        public override string ToString() 
            => _parameters.Aggregate(_Template1, (sender, kvp) 
                => sender.Replace(kvp.Key, kvp.Value));
    }
}