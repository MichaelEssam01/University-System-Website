using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementsSystem.Models
{
    public class Department
    {
        [Key]
        public long DepartmentID { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public virtual ICollection<User>? Users { get; set; } // Navigation property
        public virtual ICollection<Course>? Courses { get; set; } // Navigation property

    }
}