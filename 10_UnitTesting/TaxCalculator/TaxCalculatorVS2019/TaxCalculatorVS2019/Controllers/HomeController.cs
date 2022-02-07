using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxCalculatorVS2019.Models;

namespace TaxCalculatorVS2019.Controllers
{
    public class HomeController : Controller
    {
        decimal income = 45000;
    
        ITaxCalculator calc;

        public HomeController(ITaxCalculator calcPassedIn)
        {
            calc = calcPassedIn;
        }

        public ActionResult Index()
        {
            
            decimal tax = calc.FindTaxAmount(income);
            return View(tax);
        }
    }
}