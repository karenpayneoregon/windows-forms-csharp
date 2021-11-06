using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary.Classes
{
    public class Class1
    {
        public static void Tester()
        {
            Debug.WriteLine(AssemblyHelpers.IsExecutable());
        }
    }
}
