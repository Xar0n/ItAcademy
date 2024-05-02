using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DAL.Data
{
    public class AcademyContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Employees { get; set; }


        public AcademyContext(DbContextOptions<AcademyContext> options)
    : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>((c) => { 
                c.HasMany(d => d.Departments)
                .WithOne(d => d.Company)
                .HasForeignKey(c => c.CompanyId);
            });

            modelBuilder.Entity<Department>((c) =>
            {
                c.HasMany(e => e.Employees)
                .WithOne(d => d.Department)
                .HasForeignKey(c => c.DepartmentId);
            });
        }
    }
}
