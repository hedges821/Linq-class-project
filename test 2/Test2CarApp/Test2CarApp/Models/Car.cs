using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test2CarApp.Models
{
    public class Car
    {
        [Required(ErrorMessage = "Please enter the Make of your car.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please enter the Model of your car.")]
        public string Model { get; set; }
        public string Year { get; set; }
        public string Mileage { get; set; }
    }
}