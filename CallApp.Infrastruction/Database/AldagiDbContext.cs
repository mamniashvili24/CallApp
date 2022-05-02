using Microsoft.EntityFrameworkCore;
using CallApp.Infrastruction.Entity.Database;

namespace CallApp.Infrastruction.Database
{
    public class AldagiDbContext : DbContext
    {
        public AldagiDbContext(DbContextOptions<AldagiDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> People { get; set; }
    }
}