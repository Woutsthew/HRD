using Microsoft.EntityFrameworkCore;

namespace HRD.Classes.Models
{
    internal class HRDContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<SubdivisionTransfers> SubdivisionTransfers { get; set; }

        public HRDContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HRD;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.FIO)
                .HasComputedColumnSql("TRIM(CONCAT(LastName, ' ', FirstName, ' ', SecondName))");
            modelBuilder.Entity<Employee>().HasQueryFilter(e => e.DismissalDate == null);

            var s1 = new Subdivision { Id = 1, Name = "Директора" };
            var s2 = new Subdivision { Id = 2, Name = "Бухгалтерия", ParentId = s1.Id };
            var s3 = new Subdivision { Id = 3, Name = "Отдел Кадров", ParentId = s1.Id };
            modelBuilder.Entity<Subdivision>().HasData(s1, s2, s3);

            var e1 = new Employee { Id = 1, FirstName = "Иван", LastName = "Иванов", SubdivisionId = s1.Id,
                HireDate = new DateTime(2023, 5, 1, 0, 0, 0), DismissalDate = new DateTime(2023, 5, 3, 0, 0, 0) };
            var e2 = new Employee { Id = 2, FirstName = "Татьяна", LastName = "К", SubdivisionId = s2.Id, HireDate = new DateTime(2023, 5, 1, 0, 0, 0) };
            var e3 = new Employee { Id = 3, FirstName = "Виолетта", LastName = "В", SubdivisionId = s3.Id, HireDate = new DateTime(2023, 5, 1, 0, 0, 0) };

            var st1 = new SubdivisionTransfers { Id = 1, EmployeeId = e3.Id, FromSubdivisionId = e3.SubdivisionId,
                ToSubdivisionId = s2.Id, atDateTime = new DateTime(2023, 5, 4, 0, 0, 0) };
            e3.SubdivisionId = s2.Id;
            modelBuilder.Entity<SubdivisionTransfers>().HasData(st1);

            var e4 = new Employee { Id = 4, FirstName = "Николай", LastName = "С", SubdivisionId = s1.Id, HireDate = new DateTime(2023, 5, 3, 0, 0, 0) };
            var e5 = new Employee { Id = 5, FirstName = "Светлана", LastName = "М", SubdivisionId = s3.Id, HireDate = new DateTime(2023, 5, 4, 0, 0, 0) };
            modelBuilder.Entity<Employee>().HasData(e1, e2, e3, e4, e5);
        }
    }
}
