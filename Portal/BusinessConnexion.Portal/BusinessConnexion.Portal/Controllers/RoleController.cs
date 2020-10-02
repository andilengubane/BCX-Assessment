using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessConnexion.Portal.Controllers
{
    public class RoleController : Controller
    {
        public ActionResult CreateRole()
        {
            return View();
        }

        public ActionResult EditRole()
        {
            return PartialView();
        }
    }
}