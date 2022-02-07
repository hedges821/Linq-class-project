using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WalmartGreeter.Models;

namespace WalmartGreeter.Controllers
{
    public class HomeController : Controller
    {
        IGreeter myGreeter;

        public HomeController(IGreeter greeterPassedIn)
        {
            myGreeter = greeterPassedIn;            
        }

        // GET: Home
        public ActionResult Index()
        {
            
            ViewBag.Greeting = myGreeter.SayHi();
            ViewBag.TheImagePath = myGreeter.TheImagePath();
            return View();
        }
    }
}