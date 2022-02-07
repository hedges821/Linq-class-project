using LINQDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQDemo.Controllers
{
    public class ProductsController : Controller
    {
        Product[] ProductArray = {
               new Product { Name = "3-Shelf Bookcase", SKU = "D34U65G9", Price = 275M, ItemsAvailable = 50},
               new Product { Name = "5-Shelf Bookcase", SKU = "L34K43F4", Price = 589M, ItemsAvailable = 25},
               new Product { Name = "Desk", SKU = "J45U65Y9", Price = 875M, ItemsAvailable = 4},
               new Product { Name = "Office Chair", SKU = "L34U65G9", Price = 125M, ItemsAvailable = 0},
               new Product { Name = "Table Lamp", SKU = "T76O65G9", Price = 24.99M, ItemsAvailable = 150}
            };

        // GET: Product
        public ActionResult Index()
        {
            return View(ProductArray);
        }
        public ActionResult SortedByPrice()
        {
            var sorted =
               from p in ProductArray
               orderby p.Price
               select p;
            return View("Index", sorted);
        }
        public ActionResult Over250()
        {
            var over250 =
                from p in ProductArray
                where p.Price > 250M
                orderby p.Price
                select p;
            return View("Index", over250);
        }
        public ActionResult CheapStuff()
        {
            var under100 =
             from p in ProductArray
             where p.Price < 100M
             orderby p.Price
             select p;
            return View("Index", under100);
        }
        public ActionResult LowStock()
        {
            var lowStock =
             from p in ProductArray
             where p.ItemsAvailable < 20 && p.ItemsAvailable > 0
             orderby p.Name
             select p;
            return View("Index", lowStock);
        }
        public ActionResult OutOfStock()
        {
            var noStock =
                from p in ProductArray
                where p.ItemsAvailable == 0
                orderby p.Name
                select p;
            return View("Index", noStock);
        }

        public ActionResult Summary()
        {

            ViewBag.AvgPrice = (from p in ProductArray
                                  select p.Price).Average();

            ViewBag.MaxPrice = (from p in ProductArray
                                 select p.Price).Max();

            ViewBag.NumProducts = (from p in ProductArray 
                                     where p.ItemsAvailable > 0 
                                     select p).Count();

            return View("Summary");
        }



    }
}