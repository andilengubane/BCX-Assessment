
using System;
using System.Threading.Tasks;
using BusinessConnexion.DTO;
using BusinessConnexion.EntityFrameWork;

namespace BusinessConnexion.Service
{
    public class RoleService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static void AddEmployee(RoleDTO role)
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
