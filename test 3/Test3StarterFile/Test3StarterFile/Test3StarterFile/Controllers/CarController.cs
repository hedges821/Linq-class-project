using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3StarterFile.Models;
using System.Data.Entity;

namespace Test3StarterFile.Controllers
{
    public class CarController : Controller
    {
        ICarRepository repository;
        public CarController(ICarRepository carPassedIn)
        {
            repository = carPassedIn;
        }
        // GET: Car
        public ActionResult InventoryList()
        {
            IEnumerable<Car> Cars = repository.Cars;

            return View(Cars);

        }
        public ActionResult SortByMiles()
        {
            var sorted =
                from c in repository.Cars
                orderby c.Miles
                select c;
            return View("InventoryList", sorted);

        }

    }
    

}