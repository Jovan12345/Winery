using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    [HandleError]
    public class KolicinaController : Controller    
    {
        WineryDBEntities kolEntity;
        
        public KolicinaController()
        {
            kolEntity = new WineryDBEntities();
        }
        public ActionResult KolicinaAction()
        {
            ViewData.Model = kolEntity.KolicinaVinoes.ToList();
            var obj = (from b in kolEntity.KolicinaVinoes
                       select new { b.Vino.ImeVino, b.Kolicina }).ToList();
            return View();
        }
    }
}