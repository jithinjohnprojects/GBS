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
    public class EmployeeMasterController : Controller
    {
        private SMART_GBSEntities db = new SMART_GBSEntities();

        // GET: EmployeeMaster
        public ActionResult Index()
        {
            return View(db.EmpMasters.ToList());
        }

        // GET: EmployeeMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.EmpMasters.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // GET: EmployeeMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeMaster/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpNo,FirstName,MiddleName,SurName,PassportName,DOB,BirthPlace,Gender,ContactPerson,Nationality,BloodGroup,MaritialStatus,Remarks")] EmpMaster empMaster)
        {
            if (ModelState.IsValid)
            {
                empMaster.Date = DateTime.Now;
                empMaster.Active = 1;
                empMaster.rec_status = 1;
                db.EmpMasters.Add(empMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empMaster);
        }

        // GET: EmployeeMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.EmpMasters.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // POST: EmployeeMaster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpID,EmpNo,FirstName,MiddleName,SurName,PassportName,DOB,BirthPlace,Gender,ContactPerson,Nationality,BloodGroup,MaritialStatus,Active,Date,Remarks,rec_status")] EmpMaster empMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empMaster);
        }

        // GET: EmployeeMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpMaster empMaster = db.EmpMasters.Find(id);
            if (empMaster == null)
            {
                return HttpNotFound();
            }
            return View(empMaster);
        }

        // POST: EmployeeMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpMaster empMaster = db.EmpMasters.Find(id);
            db.EmpMasters.Remove(empMaster);
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
