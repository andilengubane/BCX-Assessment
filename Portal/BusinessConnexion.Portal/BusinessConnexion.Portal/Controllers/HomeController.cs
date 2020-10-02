using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessConnexion.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Task()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Roles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}