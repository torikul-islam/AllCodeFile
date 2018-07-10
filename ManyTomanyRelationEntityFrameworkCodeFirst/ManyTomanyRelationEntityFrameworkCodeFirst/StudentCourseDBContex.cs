using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManyTomanyRelationEntityFrameworkCodeFirst
{
    public class StudentCourseDBContex : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(t => t.Courses)
                .WithMany(t => t.Students)
                .Map(m =>
                {
                    m.ToTable("StudentCourses");
                    m.MapLeftKey("StudentID");
                    m.MapRightKey("CourseID");

                });

            base.OnModelCreating(modelBuilder);
        }
    }
}