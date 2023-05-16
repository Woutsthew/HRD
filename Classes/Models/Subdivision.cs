using System.ComponentModel.DataAnnotations;

namespace HRD.Classes.Models
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
