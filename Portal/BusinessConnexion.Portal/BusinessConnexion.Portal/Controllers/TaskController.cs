using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessConnexion.Portal.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Task()
        {
            return View();
        }

        // GET: Task
        public ActionResult EditTask(int Id)
        {
            return PartialView();
        }

        // GET: Task
        public ActionResult CreateTask()
        {
            return View();
        }
    }
}