using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS275_Test1.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Mileage { get; set; }
        public decimal Price { get; set; }
        public int DealershipID { get; set; }
        public virtual Dealership Dealership { get; set; }
    }
}