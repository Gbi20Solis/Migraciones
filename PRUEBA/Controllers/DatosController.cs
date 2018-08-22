﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRUEBA.Models;

namespace PRUEBA.Controllers
{
    public class DatosController : Controller
    {
        private PRUEBAContext db = new PRUEBAContext();

        // GET: Datos
        public ActionResult Index()
        {
            return View(db.AlumnosDatos.ToList());
        }

        // GET: Datos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosDatos alumnosDatos = db.AlumnosDatos.Find(id);
            if (alumnosDatos == null)
            {
                return HttpNotFound();
            }
            return View(alumnosDatos);
        }

        // GET: Datos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombres,Apellidos,Direccion,Telefono,Email")] AlumnosDatos alumnosDatos)
        {
            if (ModelState.IsValid)
            {
                db.AlumnosDatos.Add(alumnosDatos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumnosDatos);
        }

        // GET: Datos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosDatos alumnosDatos = db.AlumnosDatos.Find(id);
            if (alumnosDatos == null)
            {
                return HttpNotFound();
            }
            return View(alumnosDatos);
        }

        // POST: Datos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombres,Apellidos,Direccion,Telefono,Email")] AlumnosDatos alumnosDatos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumnosDatos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumnosDatos);
        }

        // GET: Datos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnosDatos alumnosDatos = db.AlumnosDatos.Find(id);
            if (alumnosDatos == null)
            {
                return HttpNotFound();
            }
            return View(alumnosDatos);
        }

        // POST: Datos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AlumnosDatos alumnosDatos = db.AlumnosDatos.Find(id);
            db.AlumnosDatos.Remove(alumnosDatos);
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
