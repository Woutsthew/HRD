﻿using System.ComponentModel.DataAnnotations;

namespace HRD.Models
{
    internal class Subdivision
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public int? ParentId { get; set; }
        public Subdivision? Parent { get; set; }
        public List<Subdivision> Childrens { get; set; } = new();

        public List<Employee> Employees { get; set; } = new();
    }
}
