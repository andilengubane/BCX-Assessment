using System;
using System.Web.Http;
using BusinessConnexion.DTO;
using BusinessConnexion.Service;

namespace BusinessConnexion.Web.Controllers
{
    public class TaskController : ApiController
    {
        // POST: api/Role
        [HttpPost]
        public string AddTask(TaskDTO model)
        {
            if (!String.IsNullOrWhiteSpace(model.Name))
            {
                TaskService.AddEmployee(model);
                return "Something went wrong with collection.";
            }
            return "Something went wrong with collection.";
        }
    }
}
