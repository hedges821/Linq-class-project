using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CodeFirst.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [DisplayName("Department")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email is required.")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Phone is required.")]
        [Phone(ErrorMessage ="Please enter a valid phone number")]
        public string Phone { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}