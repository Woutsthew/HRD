using Microsoft.EntityFrameworkCore;

namespace HRD.Classes.Model
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

            var s1 = new Subdivision { Id = 1, Name = "A" };
            var s2 = new Subdivision { Id = 2, Name = "B", ParentId = s1.Id };
            var s3 = new Subdivision { Id = 3, Name = "C", ParentId = s1.Id };
            modelBuilder.Entity<Subdivision>().HasData(s1, s2, s3);

            var e1 = new Employee { Id = 1, FirstName = "w", LastName = "q", SubdivisionId = s1.Id };
            var e2 = new Employee { Id = 2, FirstName = "s", LastName = "a", SubdivisionId = s2.Id };
            var e3 = new Employee { Id = 3, FirstName = "x", LastName = "z", SubdivisionId = s2.Id };
            var e4 = new Employee { Id = 4, FirstName = "r", LastName = "r", SubdivisionId = s1.Id, DismissalDate = new DateTime(2023, 5, 14, 13, 0, 0) };
            modelBuilder.Entity<Employee>().HasData(e1, e2, e3, e4);

            var st1 = new SubdivisionTransfers { Id = 1, EmployeeId = e2.Id, FromSubdivisionId = e2.SubdivisionId, ToSubdivisionId = s3.Id };
            e2.SubdivisionId = s3.Id;
            modelBuilder.Entity<SubdivisionTransfers>().HasData(st1);

        }

    }
}
