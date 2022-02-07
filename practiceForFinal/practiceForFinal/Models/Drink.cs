using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace practiceForFinal.Models
{
    public class Drink
    {
        public int DrinkID { get; set; }
        [Required(ErrorMessage = "Please enter the name of the drink")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the name of the drink's brand")]
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsItAlcoholic { get; set; }
    }
}