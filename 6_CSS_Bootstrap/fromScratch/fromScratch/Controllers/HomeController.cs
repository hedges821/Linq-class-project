using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fromScratch.Models;

namespace fromScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.NewYear = DateTime.Now.Year + 1;
            return View();
        }

        // RSVP form
        [HttpGet]
        public ActionResult rsvpForm()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult rsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}