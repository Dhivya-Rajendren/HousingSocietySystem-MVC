using Microsoft.EntityFrameworkCore;

namespace HousingSocietySystem_MVC.Models
{
    public class HousingSocietyDbContext:DbContext
    {
        public HousingSocietyDbContext()
        {

        }

        public HousingSocietyDbContext(DbContextOptions<HousingSocietyDbContext> options):base(options)
        {

        }


        public DbSet<Flat> Flats { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Dhivya-pc\\Sqlexpress;Database=MVC-HousingSociety;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flat>().Property(p => p.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Maintenance>().Property(p => p.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Flat>().HasQueryFilter(p => p.IsActive == true);
            modelBuilder.Entity<Maintenance>().HasQueryFilter(p => p.IsActive == true);















        }

    }
}
