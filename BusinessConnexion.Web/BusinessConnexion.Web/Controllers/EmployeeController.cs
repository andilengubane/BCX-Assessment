using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using BusinessConnexion.DTO;
using BusinessConnexion.Service;


namespace BusinessConnexion.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public string AddEmployee(EmployeeDTO employee)
        {
            if (!String.IsNullOrEmpty(employee.IdNumber))
            {
                EmployeeService.AddEmployee(employee);
                return "Employee Added Succefully";
            }
            return "Something went adding employe Id number was not provided";
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
