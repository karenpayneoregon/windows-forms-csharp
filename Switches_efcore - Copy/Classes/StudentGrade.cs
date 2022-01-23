using System;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace - must be this namespace
namespace Switches.Models
{
    public partial class StudentGrade
    {

        public static Expression<Func<StudentGrade, StudentEntity>> Projection
        {
            get
            {
                return (student) => new StudentEntity()
                {
                    PersonID = student.StudentID,
                    CourseID = student.CourseID,
                    FirstName = student.Student.FirstName,
                    LastName = student.Student.LastName,
                    Grade = student.Grade
                };
            }
        }

    }
}