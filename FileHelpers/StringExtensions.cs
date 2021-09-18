
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace FileHelpers
{
    public static class StringExtensions
    {
        public static string StringBetweenQuotes(this string sender)
        {
            Match match = Regex.Match(sender, "'([^']*)");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return sender;
            }
        }

        public static bool ContainsAny(this string sender, params string[] values)
        {
            return values.Any((value) => sender.Contains(value));
        }
    }

}