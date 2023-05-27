using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19_Q2
{
    public class DataBaseContext : DbContext
    {
        public DbSet<CategoryEmployee> categoryEmployees { get; set; }

        public DbSet<ManagerEmployee> managerEmployees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW19_Q2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEmployee>().HasOne(m => m.Manager).WithMany(c => c.Categorys)
           .HasForeignKey(e => e.ManagerId)
           .IsRequired();

        }
    }
}
