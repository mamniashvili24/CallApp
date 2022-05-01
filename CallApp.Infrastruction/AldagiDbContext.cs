using CallApp.Infrastruction.Entity;
using Microsoft.EntityFrameworkCore;

namespace CallApp.Infrastruction
{
    public class AldagiDbContext : DbContext
    {
        public AldagiDbContext(DbContextOptions<AldagiDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> People { get; set; }
    }
}