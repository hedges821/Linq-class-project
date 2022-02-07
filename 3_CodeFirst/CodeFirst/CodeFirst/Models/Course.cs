using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Course
    {
        public int CourseID { get; set;}

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}