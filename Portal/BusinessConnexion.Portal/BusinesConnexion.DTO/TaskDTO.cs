using System;

namespace BusinesConnexion.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateLogged { get; set; }
    }
}
