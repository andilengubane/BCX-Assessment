using System;
using System.ComponentModel.DataAnnotations;

namespace BusinesConnexion.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime DateLogged { get; set; }
    }
}
