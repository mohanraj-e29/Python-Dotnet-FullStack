using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class entityController : Controller
    {
        private product1Entities db = new product1Entities();

        //
        // GET: /entity/

        public ActionResult Index()
        {
            return View(db.details.ToList());
        }

        //
        // GET: /entity/Details/5

        public ActionResult Details(int id = 0)
        {
            detail detail = db.details.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }

        //
        // GET: /entity/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /entity/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(detail detail)
        {
            if (ModelState.IsValid)
            {
                db.details.Add(detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detail);
        }

        //
        // GET: /entity/Edit/5

        public ActionResult Edit(int id = 0)
        {
            detail detail = db.details.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }

        //
        // POST: /entity/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(detail detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detail);
        }

        //
        // GET: /entity/Delete/5

        public ActionResult Delete(int id = 0)
        {
            detail detail = db.details.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }

        //
        // POST: /entity/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            detail detail = db.details.Find(id);
            db.details.Remove(detail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}