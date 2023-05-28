using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19__Q3_Q4
{
    public class CPDataB : DbContext
    {
        public DbSet<ProductHW19> productHW19s { get; set; }

        public DbSet<CategoryHW19> categoryHW19s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW19_Q3+4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductHW19>().HasMany(c => c.CategoriesList).WithMany(p => p.ProductsList);
        }
    }
}
