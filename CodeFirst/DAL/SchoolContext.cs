using CodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst.DAL
{
    public class SchoolContext: DbContext
    {
        // The name of the connection string  is passed in to the constructor.
        public SchoolContext() : base("SchoolContext")
        {
        }

        // table names
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        // The modelBuilder.Conventions.Remove statement in the OnModelCreating method
        // prevents table names from being pluralized.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}