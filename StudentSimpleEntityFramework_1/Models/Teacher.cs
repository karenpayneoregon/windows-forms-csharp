using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSimpleEntityFramework_1.Models
{
    [Table("Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        public int TeacherId { get; set; }

        [StringLength(50)]
        public string TeacherName { get; set; }

        public int? StandardId { get; set; }

        public int? TeacherType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        public virtual Standard Standard { get; set; }
    }
}
