using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;

namespace AuthenticationLab_MikeHedges.Models
{
    public class Cereal
    {
        public int CerealID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}