using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace authenticationPractice.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        [DisplayName("Publisher Name")]
        public string PublisherName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}