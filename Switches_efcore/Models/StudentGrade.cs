#nullable disable

// ReSharper disable once CheckNamespace - must be this namespace
namespace Switches.Models
{
    public partial class StudentGrade
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }

        public virtual Person Student { get; set; }
    }
}