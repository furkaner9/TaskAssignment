﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaskAssignment.Models.DateContext;
using TaskAssignment.Models.Personel;

namespace TaskAssignment.Controllers
{
    public class PersonelBilgilerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: PersonelBilgileris
        public ActionResult Index()
        {
            return View(db.PersonelBilgileris.ToList());
        }
        public ActionResult PersonelKart()
        {
            return View(db.PersonelBilgileris.ToList());
        }

        // GET: PersonelBilgileris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonelBilgileris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonelBilgileriId,Eposta,Sifre,Yetki,AdSoyad,TCNO,Departman,Gorev,pozisyonAcıklama,TelNO,Adres,MedeniHal,YakınBilgisi,YakınTcNo,YakınAdsoyad,YakınTel,DogumTarihi,IseGirisTarihi")] PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.PersonelBilgileris.Add(personelBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // POST: PersonelBilgileris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonelBilgileriId,Eposta,Sifre,Yetki,AdSoyad,TCNO,Departman,Gorev,pozisyonAcıklama,TelNO,Adres,MedeniHal,YakınBilgisi,YakınTcNo,YakınAdsoyad,YakınTel,DogumTarihi,IseGirisTarihi")] PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
        //    if (personelBilgileri == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(personelBilgileri);
        //}

        //// POST: PersonelBilgileris/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
        //    db.PersonelBilgileris.Remove(personelBilgileri);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();

            }
            var t = db.PersonelBilgileris.Find(Id);

            db.PersonelBilgileris.Remove(t);
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
