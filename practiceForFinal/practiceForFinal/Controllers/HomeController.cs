using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practiceForFinal.Models;

namespace practiceForFinal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CurrentDate = DateTime.Today.ToString("d");
            
            return View();
        }

        [HttpGet]
        public ActionResult IndexLink()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IndexLink(Drink drink)
        {
            return View("Thanks", drink);
        }
    }
}