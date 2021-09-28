using Microsoft.EntityFrameworkCore;
using WorldCities.Data.Models;

namespace WorldCitites.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<City>().HasKey(x => x.Id);
            modelBuilder.Entity<City>().Property(x => x.Id).IsRequired();

            modelBuilder.Entity<City>().ToTable("Countries");
            modelBuilder.Entity<Country>().HasKey(x => x.Id);
            modelBuilder.Entity<Country>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<City>().HasOne(x => x.Country).WithMany(y => y.Cities).HasForeignKey(x => x.CountryId);
        }

        public ApplicationDbContext(DbContextOptions options)
        {}

        public DbSet<City> Cities {get; set;}
        public DbSet<Country> Countries {get; set;}
    }
}