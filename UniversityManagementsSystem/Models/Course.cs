using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UniversityManagementsSystem.Models
{
    public class Course
    {
        [Key]
        public long CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        public long DepartmentID { get; set; }
        public virtual Department? Department { get; set; } // Navigation property

        public int Credits { get; set; }

        public virtual ICollection<Enrollment>? Enrollments { get; set; } // Navigation property
    }
}