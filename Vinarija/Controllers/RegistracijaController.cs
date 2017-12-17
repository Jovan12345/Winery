using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    public class RegistracijaController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            WineryDBEntities db = new WineryDBEntities();
            return View();
        }
        public ActionResult SaveRecord(Kupuvac model)
        {
            try
            {
                WineryDBEntities db = new WineryDBEntities();

                Kupuvac kup = new Kupuvac();
                kup.Ime = model.Ime;
                kup.Prezime = model.Prezime;
                kup.adresa = model.adresa;
                kup.email = model.adresa;
                kup.Godini = model.Godini;
                kup.tel = model.Godini;
                kup.pass = model.pass;
                kup.username = model.username;

                db.Kupuvacs.Add(kup);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
           return RedirectToAction("Index","Home");
        }
    }
}