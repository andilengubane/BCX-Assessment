
using System;
using System.Linq;
using System.Web.Mvc;
using BusinessConnexion.DTO;
using System.Collections.Generic;
using BusinessConnexion.EntityFrameWork;

namespace BusinessConnexion.Service
{
    public class RoleService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static IEnumerable<SelectListItem> GetTask()
        {
            var query = context.Role.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return new SelectList(query, "Value", "Text");
        }

        public static void AddRole(RoleDTO role)
        {
            if (role.Id == 0)
            {
                context.Role.Add(new Role
                {
                    Name = role.Name,
                    Description = role.Description,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public static void EditEmployee(int taskId, RoleDTO role)
        {
            if (role.Id > 0)
            {
                var data = context.Role.Find(taskId);
                data.Id = role.Id;
                data.Name = role.Name;
                data.Description = role.Description;
                context.SaveChanges();
            }
        }
    }
}
