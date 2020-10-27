using BusinessConnexion.DTO;
using System;
using System.Web.Http;
using BusinessConnexion.Service;

namespace BusinessConnexion.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        public string AddEmployee(EmployeeDTO employee)
        {
            if (!String.IsNullOrEmpty(employee.IdNumber))
            {
                EmployeeService.AddEmployee(employee);
                return "Employee Added Succefully";
            }
            return "Something went adding employe Id number was not provided";
        }
    }
}
