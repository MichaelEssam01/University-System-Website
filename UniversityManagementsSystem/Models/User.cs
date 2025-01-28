using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementsSystem.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }
        [Required]
        public string UniversityId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; }

        public long DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
    }
}