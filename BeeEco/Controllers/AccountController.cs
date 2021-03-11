using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeeEco.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SetProfile()
        {
            return View();
        }
        public ActionResult Calculator()
        {   

            //return RedirectToAction("Index", "Home", new { area = "Membre" });
            return View();
        }
    }
}