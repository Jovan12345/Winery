
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    [HandleError]

    public class ProizvoditeliController : Controller
    {
        WineryDBEntities poizEntities;
        public ProizvoditeliController()
        {
            poizEntities = new WineryDBEntities();
        }
        public ActionResult ProzivoditelAction()
        {
            ViewData.Model = poizEntities.ProizvoditelVinoes.ToList();
            ViewData.Model = (from proizvoditelATT in poizEntities.ProizvoditelVinoes select proizvoditelATT).ToList();
            return View();
        }
    }
}