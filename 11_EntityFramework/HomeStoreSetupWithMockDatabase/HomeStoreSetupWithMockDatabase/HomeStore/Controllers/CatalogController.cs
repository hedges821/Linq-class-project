using HomeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeStore.Controllers
{
    public class CatalogController : Controller
    {
        IProductRepository repository;
        public CatalogController(IProductRepository repPassedIn)
        {
            repository = repPassedIn;
        }
                
        // GET: Catalog
        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}