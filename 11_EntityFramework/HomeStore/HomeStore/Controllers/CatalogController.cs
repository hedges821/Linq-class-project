using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeStore.Models;

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
            return View(repository.Products.OrderBy(p => p.Price));
        }

        public ActionResult Edit(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            ViewBag.CategoryID = new SelectList(repository.Categories, "CategoryID", "CategoryName",
                product.CategoryID);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("List");
            }
            else
            {
                return View(product);
            }
        }

        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(repository.Categories, "CategoryID",
                "CategoryName");
            return View("Edit", new Product());
        }
    }
}