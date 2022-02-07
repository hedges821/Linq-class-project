using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Test2CarApp.Models;

namespace Test2CarApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CarForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CarForm(Car car)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", car);
            }
            else
            {
                return View();
            }
        }
    }
}