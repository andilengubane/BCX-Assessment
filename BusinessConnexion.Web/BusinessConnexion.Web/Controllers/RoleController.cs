using System;
using System.Web.Http;
using BusinessConnexion.DTO;
using BusinessConnexion.Service;

namespace BusinessConnexion.Web.Controllers
{
    public class RoleController : ApiController
    {
        // POST: api/Role
        [HttpPost]
        public string AddRole(RoleDTO model)
        {
            if (!String.IsNullOrWhiteSpace(model.Name))
            {
               RoleService.AddRole(model);
               return "Something went wrong with collection.";
            }
            return "Something went wrong with collection.";
        }
    }
}
