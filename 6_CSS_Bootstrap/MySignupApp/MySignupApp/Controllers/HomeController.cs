using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySignupApp.Models;

namespace MySignupApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CurrentDate = DateTime.Today.ToString("d");
            ViewBag.TomorrowDate = DateTime.Today.AddDays(1).ToString("d");
            return View();
        }

        // Form Get
        [HttpGet]
        public ActionResult SignUpPage()
        {
            return View();
        }

        // Form Post

        [HttpPost]
        public ActionResult SignUpPage(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", person);
            }
            else
            {
                return View();
            }
        }
    }
}