﻿using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinesConnexion.DTO
{
    public class EmployeeDOT
    {
        public int Id { get; set; }
        public int GenderId { get; set; }
        public int RileId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        public string EmployeeLast { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateLogged { get; set; }
        public IEnumerable<SelectListItem> Gender { get; set; }
        public IEnumerable<SelectListItem> Role { get; set; }
    }
}
