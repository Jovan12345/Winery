using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
        [HandleError]
    public class NarackaController : Controller
    {
        WineryDBEntities db;
        public NarackaController()
        {
            db = new WineryDBEntities();
        }
        public ActionResult Index()
        {
            ViewData.Model = db.Vinoes.ToList();
            var obj = (from b in db.Vinoes
                       select new {b.VinoID, b.ImeVino}).ToList();
            return View();
        }
        public ActionResult SaveRecord(int vino, string kolicina)
        {
            try
            {
                WineryDBEntities db = new WineryDBEntities();
                
                Naracka naracka = new Naracka();
                naracka.VinoID = vino;
                naracka.Kolicina = kolicina;


                db.Narackas.Add(naracka);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");
        }

    }
}