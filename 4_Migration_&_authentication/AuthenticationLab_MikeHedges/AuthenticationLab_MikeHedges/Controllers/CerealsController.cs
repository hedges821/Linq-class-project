using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AuthenticationLab_MikeHedges.Models;

namespace AuthenticationLab_MikeHedges.Controllers
{
    [Authorize]
    public class CerealsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cereals
        [AllowAnonymous]
        public ActionResult Index()
        {
            var cereals = db.Cereals.Include(c => c.Brand);
            return View(cereals.ToList());
        }

        // GET: Cereals/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cereal cereal = db.Cereals.Find(id);
            if (cereal == null)
            {
                return HttpNotFound();
            }
            return View(cereal);
        }

        // GET: Cereals/Create
        public ActionResult Create()
        {
            ViewBag.BrandID = new SelectList(db.Brands, "BrandID", "Name");
            return View();
        }

        // POST: Cereals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CerealID,Name,Price,Size,BrandID")] Cereal cereal)
        {
            if (ModelState.IsValid)
            {
                db.Cereals.Add(cereal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandID = new SelectList(db.Brands, "BrandID", "Name", cereal.BrandID);
            return View(cereal);
        }

        // GET: Cereals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cereal cereal = db.Cereals.Find(id);
            if (cereal == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandID = new SelectList(db.Brands, "BrandID", "Name", cereal.BrandID);
            return View(cereal);
        }

        // POST: Cereals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CerealID,Name,Price,Size,BrandID")] Cereal cereal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cereal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandID = new SelectList(db.Brands, "BrandID", "Name", cereal.BrandID);
            return View(cereal);
        }

        // GET: Cereals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cereal cereal = db.Cereals.Find(id);
            if (cereal == null)
            {
                return HttpNotFound();
            }
            return View(cereal);
        }

        // POST: Cereals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cereal cereal = db.Cereals.Find(id);
            db.Cereals.Remove(cereal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
