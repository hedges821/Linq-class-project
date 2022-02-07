using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace GiftRequests.Models
{
    public class Gift
    {
        [Required(ErrorMessage = "Please enter a gift.")]
        public string GiftName { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter a store.")]
        public string Store { get; set; }
    }
}