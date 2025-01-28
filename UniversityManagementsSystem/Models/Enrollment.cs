//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//public class Enrollment
//{
//    [Key]
//    public long EnrollmentID { get; set; }

//    // Foreign Key
//    [Required]
//    public long UserID { get; set; }

//    [ForeignKey("UserID")]
//    public User User { get; set; }

//    // Foreign Key
//    [Required]
//    public long CourseID { get; set; }

//    [ForeignKey("CourseID")]
//    public Course Course { get; set; }

//    [Required]
//    [MaxLength(255)]
//    public string Role { get; set; }

//    [Required]
//    [DataType(DataType.Date)]
//    public DateTime EnrollmentDate { get; set; }

//    [Required]
//    [MaxLength(255)]
//    public string EnrollmentStatus { get; set; }
//}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementsSystem.Models
{
    public class Enrollment
    {
        [Key]
        public long EnrollmentID { get; set; }
        [Required]
        public long UserID { get; set; }
        public virtual User? User { get; set; } // Navigation property
        [Required]
        public long CourseID { get; set; }
        public virtual Course? Course { get; set; } // Navigation property

        public DateOnly EnrollmentDate { get; set; }
    }
}