using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace MovieApp.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [DisplayName("Genre")]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}