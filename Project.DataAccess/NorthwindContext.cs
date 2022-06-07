using Microsoft.EntityFrameworkCore;
using Project.Entities;

namespace Project.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("Employees");
            //get attached personel table to the employees table
            modelBuilder.Entity<Personel>().Property(p=>p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p=>p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p=>p.Surname).HasColumnName("LastName");
            
        }
    }
}
