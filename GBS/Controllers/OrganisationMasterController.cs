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
    public class OrganisationMasterController : Controller
    {
        private SMART_GBSEntities db = new SMART_GBSEntities();

        // GET: OrganisationMaster
        public ActionResult Index()
        {
            return View(db.OrgMasters.ToList());
        }

        // GET: OrganisationMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgMaster orgMaster = db.OrgMasters.Find(id);
            if (orgMaster == null)
            {
                return HttpNotFound();
            }
            return View(orgMaster);
        }

        // GET: OrganisationMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrganisationMaster/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrgId,OrgName,RegAddress,CorpAddress,Date")] OrgMaster org)
        {
            if (ModelState.IsValid)
            {
                db.OrgMasters.Add(org);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(org);
        }

        // GET: OrganisationMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgMaster orgMaster = db.OrgMasters.Find(id);
            if (orgMaster == null)
            {
                return HttpNotFound();
            }
            return View(orgMaster);
        }

        // POST: OrganisationMaster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrgId,OrgName,RegAddress,CorpAddress,Date")] OrgMaster orgMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orgMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orgMaster);
        }

        // GET: OrganisationMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrgMaster orgMaster = db.OrgMasters.Find(id);
            if (orgMaster == null)
            {
                return HttpNotFound();
            }
            return View(orgMaster);
        }

        // POST: OrganisationMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrgMaster orgMaster = db.OrgMasters.Find(id);
            db.OrgMasters.Remove(orgMaster);
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
