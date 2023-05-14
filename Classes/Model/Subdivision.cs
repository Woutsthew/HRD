using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD.Classes.Model
{
    internal class Subdivision
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public int? ParentId { get; set; }
        public Subdivision? Parent { get; set; }
        public List<Subdivision> Children { get; set; } = new();

        public List<Employee> Employees { get; set; } = new();
    }
}
