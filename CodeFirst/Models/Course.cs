using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // ICollection<Enrollment>: to generate list of items
        // Enrollments: navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}