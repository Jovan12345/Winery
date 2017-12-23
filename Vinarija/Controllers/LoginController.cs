using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vinarija.Models;

namespace Vinarija.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Kupuvac objUser)
        {
            if (ModelState.IsValid)
            {
                using (WineryDBEntities db = new WineryDBEntities())
                {
                    var obj = db.Kupuvacs.Where(a => a.username.Equals(objUser.username) && a.pass.Equals(objUser.pass)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.KupuvacID.ToString();
                        Session["UserName"] = obj.username.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}