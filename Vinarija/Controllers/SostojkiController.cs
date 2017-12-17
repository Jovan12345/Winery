using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    [HandleError]
    public class SostojkiController : Controller
    {
        WineryDBEntities sostojkiEntities;

        public SostojkiController()
        {
            sostojkiEntities = new WineryDBEntities();

        }
     
       
        public ActionResult Index()
        {
            ViewData.Model = sostojkiEntities.SostojkiVinoes.ToList();

            var obj = (from b in sostojkiEntities.SostojkiVinoes                      
                       select new { b.Grozje, b.Ostanato, b.Seker, b.Vino.ImeVino, b.Voda }).ToList();
            return View();
        }
        public ActionResult IndexDalvina()
        {
            ViewData.Model = sostojkiEntities.SostojkiVinoes.ToList();

            var obj = (from b in sostojkiEntities.SostojkiVinoes
                       select new { b.Grozje, b.Ostanato, b.Seker, b.Vino.ImeVino, b.Voda }).ToList();
            return View();
        }
        public ActionResult IndexStobi()
        {
            ViewData.Model = sostojkiEntities.SostojkiVinoes.ToList();

            var obj = (from b in sostojkiEntities.SostojkiVinoes
                       select new { b.Grozje, b.Ostanato, b.Seker, b.Vino.ImeVino, b.Voda }).ToList();
            return View();
        }
        public ActionResult IndexTikves()
        {
            ViewData.Model = sostojkiEntities.SostojkiVinoes.ToList();

            var obj = (from b in sostojkiEntities.SostojkiVinoes
                       select new { b.Grozje, b.Ostanato, b.Seker, b.Vino.ImeVino, b.Voda }).ToList();
            return View();
        }
    }
}