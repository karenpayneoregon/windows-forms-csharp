using StudentSimpleEntityFramework_1.Models;

namespace StudentSimpleEntityFramework_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        public DbGeography Location { get; set; }

        public int? TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
