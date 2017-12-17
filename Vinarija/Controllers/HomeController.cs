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
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VinoActionTikves()
        {
         ViewData.Model = wEntities.Vinoes.ToList();
                           var obj = (from b in wEntities.Vinoes
                            select b);
            return View();
        }
        public ActionResult VinoActionBovin()
        {
            ViewData.Model = wEntities.Vinoes.ToList();
            var obj = (from b in wEntities.Vinoes select b);
            return View();
        }
        public ActionResult VinoActionDalvina()
        {
            ViewData.Model = wEntities.Vinoes.ToList();
            var obj = (from b in wEntities.Vinoes select b);
            return View();
        }
        public ActionResult VinoActionStobi()
        {
            ViewData.Model = wEntities.Vinoes.ToList();
            var obj = (from b in wEntities.Vinoes select b);
            return View();
        }
    }
}