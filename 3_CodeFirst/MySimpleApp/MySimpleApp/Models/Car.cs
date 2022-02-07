using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySimpleApp.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public decimal Price { get; set; }
    }
}