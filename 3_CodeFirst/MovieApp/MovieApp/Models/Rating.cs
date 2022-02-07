using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace MovieApp.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        [DisplayName("Rating")]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}