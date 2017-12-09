using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;
namespace Vinarija.Controllers
{
    [HandleError]
    public class VinoController : Controller
    {
        WineryDBEntities vinoEntity;
        public VinoController()
        {
            vinoEntity = new WineryDBEntities();
        }
        // GET: Vino
        public ActionResult VinoAction()
        {
            ViewData.Model = vinoEntity.Vinoes.ToList();
            var obj = (from b in vinoEntity.Vinoes
                       select new { b.ImeVino, b.TipVino.TipVino1, b.ProizvoditelVino.ProizvoditelVinoIme, b.GodinaProizvdostvo,b.Cena  }).ToList();
            return View();
        }
    }
}