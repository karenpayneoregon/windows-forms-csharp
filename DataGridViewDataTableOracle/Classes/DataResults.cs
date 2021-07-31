using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewDataTableOracle.Classes
{
    public class DataResults
    {
        public DataTable DataTable { get; set; }
        public bool Success { get; set; }
        public Exception Exception { get; set; }
    }
}
