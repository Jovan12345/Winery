using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    [HandleError]

    public class HomeController : Controller
    {
        WineryDBEntities wEntities;
        public HomeController()
        {
            wEntities = new WineryDBEntities();
        }
        public ActionResult Index()
        {
            ViewData.Model = wEntities.Vinoes.ToList();
            ViewData.Model = (from w in wEntities.Vinoes select w).ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Proizvoditeli na klasno vino.";
            ViewData.Model = wEntities.ProizvoditelVinoes.ToList();
            ViewData.Model = (from w in wEntities.ProizvoditelVinoes select w.ProizvoditelVinoIme).ToList();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}