using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modele.Faucheux;
using Modele.Faucheux.Entities;

namespace WebStudent.Controllers
{
    public class AbsenceController : Controller
    {
        private Context db = new Context();

        // GET: Absence
        public ActionResult Index()
        {
            var absences = db.Absences.Include(a => a.Eleve);
            return View(absences.ToList());
        }

        // GET: Absence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }

        // GET: Absence/Create
        public ActionResult Create()
        {
            ViewBag.EleveID = new SelectList(db.Eleves, "EleveID", "Nom");
            return View();
        }

        // POST: Absence/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AbsenceID,DateAbsence,Motif,EleveID")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Absences.Add(absence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EleveID = new SelectList(db.Eleves, "EleveID", "Nom", absence.EleveID);
            return View(absence);
        }

        // GET: Absence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            ViewBag.EleveID = new SelectList(db.Eleves, "EleveID", "Nom", absence.EleveID);
            return View(absence);
        }

        // POST: Absence/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AbsenceID,DateAbsence,Motif,EleveID")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(absence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EleveID = new SelectList(db.Eleves, "EleveID", "Nom", absence.EleveID);
            return View(absence);
        }

        // GET: Absence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }

        // POST: Absence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Absence absence = db.Absences.Find(id);
            db.Absences.Remove(absence);
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
