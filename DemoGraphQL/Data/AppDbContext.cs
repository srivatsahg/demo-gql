using Microsoft.EntityFrameworkCore;
using DemoGraphQL.Models;

namespace DemoGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
