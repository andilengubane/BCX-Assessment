using System;
using System.Linq;
using System.Web.Mvc;
using BusinessConnexion.DTO;
using System.Collections.Generic;
using BusinessConnexion.EntityFrameWork;


namespace BusinessConnexion.Service
{
    public class EmployeeService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static List<EmployeeDTO> GetAllEmployeeDetails(string employeeCode, string employeeFullName)
        {
           
        }

        public static void AddEmployee(EmployeeDTO employee)
        {
            if (employee.Id == 0)
            {
                context.Employee.Add(new Employee
                {
                    EmployeeName = employee.EmployeeName,
                    EmployeeLast = employee.EmployeeLast,
                    PhoneNumber = employee.PhoneNumber,
                    IdNumber = employee.IdNumber,
                    GenderId = employee.GenderId,
                    RileId = employee.RileId,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public static void EditEmployee(int employeeId, EmployeeDTO employeeData)
        {

            if (employeeData != null)
            {
                var data = context.Employee.Find(employeeId);
                data.Id = employeeData.Id;
                context.SaveChanges();
            }
        }

        public static void AssignTask(TaskDTO assignInventory)
        {
            context.AssignedTask.Add(new AssignedTask
            {
                DateLogged = DateTime.Now
            });
            context.SaveChanges();
        }

        public static EmployeeDTO UpdateEmployee(int employeeId)
        {
            var employeeData = new EmployeeDTO();
            var data = context.Employee.Where(s => s.Id == employeeId).FirstOrDefault();
            employeeData.Id = data.Id;
            employeeData.IdNumber = data.IdNumber;
            employeeData.PhoneNumber = data.PhoneNumber;
            return employeeData;
        }
    }
}
