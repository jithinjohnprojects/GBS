using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GBS.Models;

namespace GBS.Controllers
{
    public class CategoryColorController : Controller
    {
        private SMART_GBSEntities db = new SMART_GBSEntities();

        // GET: Category_Color_
        public ActionResult Index()
        {
            return View(db.Category_Color.ToList());
        }

        // GET: Category_Color_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Color category_Color = db.Category_Color.Find(id);
            if (category_Color == null)
            {
                return HttpNotFound();
            }
            return View(category_Color);
        }

        // GET: Category_Color_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category_Color_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "color_id,color_cod,color_name")] Category_Color category_Color)
        {
            if (ModelState.IsValid)
            {
                category_Color.active = 1;
                category_Color.rec_status = 1;
                db.Category_Color.Add(category_Color);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category_Color);
        }

        // GET: Category_Color_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Color category_Color = db.Category_Color.Find(id);
            if (category_Color == null)
            {
                return HttpNotFound();
            }
            return View(category_Color);
        }

        // POST: Category_Color_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "color_id,color_cod,color_name,active,rec_status")] Category_Color category_Color)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category_Color).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category_Color);
        }

        // GET: Category_Color_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Color category_Color = db.Category_Color.Find(id);
            if (category_Color == null)
            {
                return HttpNotFound();
            }
            return View(category_Color);
        }

        // POST: Category_Color_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category_Color category_Color = db.Category_Color.Find(id);
            db.Category_Color.Remove(category_Color);
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
