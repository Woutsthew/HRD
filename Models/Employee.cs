using System.ComponentModel.DataAnnotations;

namespace HRD.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? SecondName { get; set; }
        public string? FIO { get; set; }

        [Required]
        public DateTime? HireDate { get; set; } = DateTime.Now;
        public DateTime? DismissalDate { get; set; }

        public int SubdivisionId { get; set; }
        public Subdivision? Subdivision { get; set; }

        public List<EmployeeTransfer> Transfers { get; set; } = new();
    }
}
