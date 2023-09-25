using Microsoft.EntityFrameworkCore;
using SomethingAPI.Models;

namespace SomethingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Country> Country { get; set; }
    }
}
