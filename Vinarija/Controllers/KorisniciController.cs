
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    public class KorisniciController : Controller
    {
        // GET: Korisnici
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegistrationForm(Kupuvac registration)
        {
            return View("Congratulation", registration);
        }
    }
}
