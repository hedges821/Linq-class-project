using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsForSale.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Year { get; set; }
        public string Miles { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

    }
}