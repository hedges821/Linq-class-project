using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieApp.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        [Required(ErrorMessage ="Enter a title.")]
        [DisplayName("Movie")]
        public string Name { get; set; }
        [DisplayName("Genre")]
        public int GenreID { get; set; }
        [DisplayName("Rating")]
        public int RatingID { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }
    }
}