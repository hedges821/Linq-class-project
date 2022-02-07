using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsForSale.Models;

namespace CarsForSale.Controllers
{
    public class CarController : Controller
    {
        ICarRepository carRepository;
        public CarController(ICarRepository carPassedIn)
        {
            carRepository = carPassedIn;
        }
        // GET: Car
        public ActionResult InventoryList()
        {
            return View(carRepository.Cars);
        }
    }
}