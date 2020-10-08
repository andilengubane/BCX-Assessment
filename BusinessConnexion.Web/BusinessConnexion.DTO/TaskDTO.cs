using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BusinessConnexion.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateLogged { get; set; }
       
    }
}
