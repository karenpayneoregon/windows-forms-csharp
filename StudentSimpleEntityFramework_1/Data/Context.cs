using System.Data.Entity;
using StudentSimpleEntityFramework_1.Models;

namespace StudentSimpleEntityFramework_1.Data
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=SchoolContextConnectionString")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Students)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("StudentCourse").MapLeftKey("CourseId").MapRightKey("StudentId"));

            modelBuilder.Entity<Standard>()
                .Property(e => e.StandardName)
                .IsUnicode(false);

            modelBuilder.Entity<Standard>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Standard>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Standard)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Standard>()
                .HasMany(e => e.Teachers)
                .WithOptional(e => e.Standard)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasOptional(e => e.StudentAddress)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<StudentAddress>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAddress>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAddress>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.TeacherName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Teacher)
                .WillCascadeOnDelete();
        }
    }
}
