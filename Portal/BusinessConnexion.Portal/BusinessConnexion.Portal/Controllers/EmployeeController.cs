using System;
using System.Net.Http;
using System.Web.Mvc;
using BusinesConnexion.DTO;

namespace BusinessConnexion.Portal.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee
        public ActionResult CreateEmployee()
        {
            return View();
        }

        // GET: Employee
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

        public static void AddEmployee(EmployeeDOT employee)
        {
            var baseUrl = "";
            using (var http = new HttpClient())
            {
                //var content = new StringContent(JsonConvert.SerializeObject(data));
                //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //var request = http.PostAsync($"{baseUrl}", content);
                //var response = request.Result.Content.ReadAsStringAsync().Result;

                //if (collectionOutputDTO.Status != null)
                //{
                //    return $"Status: { collectionOutputDTO.Status}, Description:{ collectionOutputDTO.Description }, ResultCode: { collectionOutputDTO.ResultCode }, Date: { collectionOutputDTO.Date }";
                //}
                //else
                //{
                //    var errorMessage = "Unable to create subscription";
                //    return errorMessage;
                //}
            }
        }
    }
}