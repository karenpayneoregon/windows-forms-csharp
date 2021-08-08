using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSimple.Classes
{

    public static class BooleanExtensions
    {
        public static string ToYesNo(this bool value) => value ? "Yes" : "No";
    }

}
