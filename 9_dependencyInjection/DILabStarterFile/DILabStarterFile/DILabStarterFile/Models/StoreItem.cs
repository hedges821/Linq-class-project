using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DILabStarterFile.Models
{
    public class StoreItem
    {
        public int StoreItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }
        public bool Discountable { set; get; }
    }
}