using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetLightDataGridViewExport.Classes
{
    public static class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string sender, string value) =>
            string.Equals(sender, value, StringComparison.OrdinalIgnoreCase);
    }
}
