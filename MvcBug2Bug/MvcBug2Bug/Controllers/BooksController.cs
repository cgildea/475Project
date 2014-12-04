using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBug2Bug.Models;

namespace MvcBug2Bug.Controllers
{
    public class BooksController : Controller
    {
        private BooksEntities db = new BooksEntities();

        //
        // GET: /Books/

        public ActionResult Index()
        {
            return View(db.Titles.ToList());
        }

        //
        // GET: /Books/Details/5

        public ActionResult Details(string id = null)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return HttpNotFound();
            }
            return View(title);
        }

        //
        // GET: /Books/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Books/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Title title)
        {
            if (ModelState.IsValid)
            {
                db.Titles.Add(title);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(title);
        }

        //
        // GET: /Books/Edit/5

        public ActionResult Edit(string id = null)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return HttpNotFound();
            }
            return View(title);
        }

        //
        // POST: /Books/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Title title)
        {
            if (ModelState.IsValid)
            {
                db.Entry(title).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(title);
        }

        //
        // GET: /Books/Delete/5

        public ActionResult Delete(string id = null)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                return HttpNotFound();
            }
            return View(title);
        }

        //
        // POST: /Books/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Title title = db.Titles.Find(id);
            db.Titles.Remove(title);
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