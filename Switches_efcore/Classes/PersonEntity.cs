using System.Collections.Generic;

namespace Switches.Models
{
    public class PersonEntity
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public ICollection<StudentGrade> Grades { get; set; }
    }
}