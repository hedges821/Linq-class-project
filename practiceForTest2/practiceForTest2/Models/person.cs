using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace practiceForTest2.Models
{
    public class person
    {
        [Required(ErrorMessage ="Please enter your first name")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter your email address")]
        public string email { get; set; }
        public bool willAttend { get; set; }

    }
}