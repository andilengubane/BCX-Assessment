using System;
using System.Net.Http;
using System.Web.Mvc;
using BusinesConnexion.DTO;
using Newtonsoft.Json;

namespace BusinessConnexion.Portal.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult CreateEmployee()
        {
            return View();
        }

        public ActionResult EditEmployee(int Id)
        {
            return PartialView();
        }
        public ActionResult AssignTask(int Id)
        {
            return PartialView();
        }
        public ActionResult TaskList(int Id)
        {
            return PartialView();
        }

        public ActionResult AddEmployee(EmployeeDOT employee)
        {
            using (var http = new HttpClient())
            {
                var baseUrl = "http://localhost:53308//api/Employee/AddEmployee";
                var content = new StringContent(JsonConvert.SerializeObject(employee));
                var request = http.PostAsync($"{baseUrl}", content);
                request.Wait();

                var result = request.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Employee");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(employee);
        }
    }
}