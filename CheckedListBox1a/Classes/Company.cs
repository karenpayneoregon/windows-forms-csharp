using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedListBox1a.Classes
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
