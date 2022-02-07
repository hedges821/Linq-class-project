using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using database.Models;

namespace database.Controllers
{
    public class CatalogController : Controller
    {
        IProductRepository repository;
        
        public CatalogController(IProductRepository repositoryPassedIn)
        {
            repository = repositoryPassedIn;
        }
        
        
        
        // GET: Catalog
        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}