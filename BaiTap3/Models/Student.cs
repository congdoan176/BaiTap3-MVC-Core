using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap3.Models
{
    public class Student
    {
        [Key]
        [Required]
        public string RollNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public StudentStatus Status { get; set; }
        public List<Mark> Marks { get; internal set; }

        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = StudentStatus.Activated;
        }      
    }
    public enum StudentStatus
    {
        Activated = 1,
        DecActivated =2
    }
}
