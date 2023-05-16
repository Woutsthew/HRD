using System.ComponentModel.DataAnnotations;

namespace HRD.Classes.Models
{
    internal class SubdivisionTransfers
    {
        public int Id { get; set; }
        [Required]
        public DateTime? atDateTime { get; set; } = DateTime.Now;

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public int? FromSubdivisionId { get; set; }
        public Subdivision? FromSubdivision { get; set; }

        public int? ToSubdivisionId { get; set; }
        public Subdivision? ToSubdivision { get; set; }
    }
}
