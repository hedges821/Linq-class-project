using DILabStarterFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DILabStarterFile.Controllers
{
    public class HomeController : Controller
    {
        IPriceCalculator calc;
        public HomeController(IPriceCalculator calcPassedIn)
        {
            calc = calcPassedIn;
        }

        StoreItem item = new StoreItem { Name = "Sofa", Category = "Furniture", Price = 935.95M, Discountable = true };

        // GET: Home
        public ActionResult Index()
        {

            //IPriceCalculator calc = new BlackFridaySalePrice();

            if (item.Discountable == true)
            {
                decimal totalValue = calc.CalcSalesPrice(item.Price);
                return View(totalValue);
            }
            else
            {
                return View(item.Price);
            }
        }
    }
}