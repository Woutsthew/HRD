using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD.Classes.Model
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

        public List<SubdivisionTransfers> Transfers { get; set; } = new();
    }
}
