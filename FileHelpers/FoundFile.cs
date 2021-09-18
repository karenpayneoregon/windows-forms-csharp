using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHelpers
{
    public class FoundFile : IEquatable<FoundFile>
    {
        public string FileName { get; set; }
        public int LineNumber { get; set; }
        public string Text { get; set; }

        public bool Equals(FoundFile other)
        {

            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(FileName, other.FileName) && LineNumber == other.LineNumber && string.Equals(Text, other.Text);
        }

        public override bool Equals(object obj)
        {

            if (obj is null)
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((FoundFile)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FileName, LineNumber, Text);
        }

        public override string ToString()
        {
            return $"{FileName}{"\r\n"}{LineNumber}{"\r\n"}{Text}";
        }
    }
}