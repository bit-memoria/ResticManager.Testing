using Microsoft.EntityFrameworkCore;

namespace ResticManager.Testing.Data
{
    public class ResticContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbSet<ResticRepository> Repositories { get; set; }
        public DbSet<ResticSnapshot> ResticSnapshots { get; set; }


        public ResticContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("ResticCacheDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResticSnapshot>()
                .Property(e => e.Paths)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            modelBuilder.Entity<ResticSnapshot>()
                .Property(e => e.Tags)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
