using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftRequests.Models;

namespace GiftRequests.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ClickHere()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClickHere(Gift gift)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", gift);
            }
            else
            {
                return View();
            }
        }
    }
}