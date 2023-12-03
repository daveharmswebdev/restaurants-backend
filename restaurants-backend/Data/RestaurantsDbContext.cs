using Microsoft.EntityFrameworkCore;
using restaurants_backend.entities;

namespace restaurants_backend.Data
{
    public class RestaurantsDbContext : DbContext
    {
        public RestaurantsDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Staff> Staff { get; set; }
    }
}