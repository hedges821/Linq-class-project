using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practiceForTest2.Models;

namespace practiceForTest2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult rsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult rsvpForm(person personSignUp)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", personSignUp);
            }
            else
            {
                return View();
            }
        }
    }
}