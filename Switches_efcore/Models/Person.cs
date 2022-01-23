using System;
using System.Collections.Generic;


#nullable disable

namespace Switches.Models
{
    public partial class Person
    {
        public Person()
        {
            StudentGrade = new HashSet<StudentGrade>();
        }

        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<StudentGrade> StudentGrade { get; set; }
    }
}