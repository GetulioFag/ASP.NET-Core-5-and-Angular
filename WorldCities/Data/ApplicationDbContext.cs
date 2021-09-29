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

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public ApplicationDbContext(DbContextOptions options)
        {}

        public DbSet<City> Cities {get; set;}
        public DbSet<Country> Countries {get; set;}
    }
}