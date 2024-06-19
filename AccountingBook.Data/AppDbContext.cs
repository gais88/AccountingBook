using AccountingBook.Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AccountingBook.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // seed company
            var company = new Company("InifintyGroup", "inf", "i001");
            company.Id = 1;
            modelBuilder.Entity<Company>().HasData(company);
        }
        public DbSet<Company> companies { get; set; }
    }
}
