using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    [HandleError]
 
    public class TipVinoController : Controller
    {
    WineryDBEntities tipEntities;
        public TipVinoController()
    {
            tipEntities = new WineryDBEntities();
        
    }
    public ActionResult TipAction()
        {
            ViewData.Model = tipEntities.TipVinoes.ToList();
            ViewData.Model = (from tippp in tipEntities.TipVinoes select tippp.TipVino1).ToList();
            return View();
        }
    }
}