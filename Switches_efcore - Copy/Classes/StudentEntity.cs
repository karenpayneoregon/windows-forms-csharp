using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace - must be this namespace
namespace Switches.Models
{
    public class StudentEntity
    {
        public int CourseID { get; set; }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Grade { get; set; }
    }
}
