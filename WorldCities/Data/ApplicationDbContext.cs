using Microsoft.EntityFrameworkCore;
using WorldCities.Data.Models;

namespace WorldCitites.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {}
        
        public ApplicationDbContext(DbContextOptions options)
        {}

        public DbSet<City> Cities {get; set;}
        public DbSet<Country> Countries {get; set;}
    }
}