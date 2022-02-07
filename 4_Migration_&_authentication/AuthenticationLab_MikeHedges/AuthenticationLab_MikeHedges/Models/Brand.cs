using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace AuthenticationLab_MikeHedges.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [DisplayName("Brand Name")]
        public string Name { get; set; }
        [DisplayName("Headquarters")]
        public string Home { get; set; }
        [DisplayName("Stock Symbol")]
        public string Stock { get; set; }
        public ICollection<Cereal> Cereals { get; set; }
    }
}