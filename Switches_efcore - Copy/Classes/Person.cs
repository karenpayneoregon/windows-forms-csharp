using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace - do not change!!!
namespace Switches.Models
{
    public partial class Person
    {

        public static Expression<Func<Person, PersonEntity>> Projection
        {
            get
            {
                return (student) => new PersonEntity()
                {
                    PersonID = student.PersonID,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Grades = student.StudentGrade
                };
            }
        }
    }
}
