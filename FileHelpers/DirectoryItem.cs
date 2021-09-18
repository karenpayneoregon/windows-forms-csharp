using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHelpers
{
    public class DirectoryItem
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Modified { get; set; }
        public string[] ItemArray => new[] { Location, Name, Modified.ToShortDateString() };
        public override string ToString() => Name;
    }

}