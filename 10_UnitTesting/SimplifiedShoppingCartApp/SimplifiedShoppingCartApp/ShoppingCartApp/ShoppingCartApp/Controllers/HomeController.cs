using ShoppingCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartApp.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products = {
            new Product {Name = "Kayak",  Price = 189.99M},
            new Product {Name = "Lifejacket", Price = 14.99M},
            new Product {Name = "Paddle Set", Price = 29.99M},
            new Product {Name = "Sunscreen", Price = 3.99M}
            };

        IValueCalculator calc;

        public HomeController(IValueCalculator calPassedIn)
        {
            calc = calPassedIn;
        }

        public ActionResult Index()
        {
            
            decimal totalValue = calc.ValueProducts(products);
            return View(totalValue);
        }
    }
}