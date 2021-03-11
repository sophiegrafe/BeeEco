using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeeEco.Controllers
{
    public class ItinaryController : Controller
    {
        // GET: Itinary
        public ActionResult NewTraject()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }
    }
}