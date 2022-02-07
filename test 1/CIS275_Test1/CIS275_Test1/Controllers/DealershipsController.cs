﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS275_Test1.Models;

namespace CIS275_Test1.Controllers
{
    [Authorize]
    public class DealershipsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dealerships
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Dealerships.ToList());
        }

        // GET: Dealerships/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dealership dealership = db.Dealerships.Find(id);
            if (dealership == null)
            {
                return HttpNotFound();
            }
            return View(dealership);
        }

        // GET: Dealerships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dealerships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DealershipID,DealershipName,Phone,Email")] Dealership dealership)
        {
            if (ModelState.IsValid)
            {
                db.Dealerships.Add(dealership);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dealership);
        }

        // GET: Dealerships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dealership dealership = db.Dealerships.Find(id);
            if (dealership == null)
            {
                return HttpNotFound();
            }
            return View(dealership);
        }

        // POST: Dealerships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DealershipID,DealershipName,Phone,Email")] Dealership dealership)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dealership).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dealership);
        }

        // GET: Dealerships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dealership dealership = db.Dealerships.Find(id);
            if (dealership == null)
            {
                return HttpNotFound();
            }
            return View(dealership);
        }

        // POST: Dealerships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dealership dealership = db.Dealerships.Find(id);
            db.Dealerships.Remove(dealership);
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
