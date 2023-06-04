using Microsoft.EntityFrameworkCore;

namespace Demos.HomeWork.ModelsDb
{
    public class URDbContext : DbContext
    {
        public DbSet<Users> _Users { get; set; }

        public DbSet<Roles> _Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW20;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasMany(R => R.rolesList).WithMany(U => U.usersList);
        }
    }

}
