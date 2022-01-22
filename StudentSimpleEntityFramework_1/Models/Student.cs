using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSimpleEntityFramework_1.Models
{
    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        public int StudentID { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }

        public int? StandardId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual Standard Standard { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        public void Deconstruct(out int identifier, out string name)
        {
            identifier = StudentID;
            name = StudentName;
        }
    }
}
