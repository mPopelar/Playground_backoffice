using Microsoft.EntityFrameworkCore;
using PlatformApi.Entities;

namespace Platform
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients", schema: "Platform");
        }

        public DbSet<Client> Clients { get; set; }
    }
}
