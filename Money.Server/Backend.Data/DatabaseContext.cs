using Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Backend.Data
{
    public class DatabaseContext : DbContext
    {
        public ILoggerFactory MyLoggerFactory { get; private set; }

        public DbSet<RawData> RawText { get; set; }

        /*
                public DbSet<Samurai> Samurais { get; set; }
                public DbSet<Battle> Battles { get; set; }
                public DbSet<Quote> Quotes { get; set; }
                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    modelBuilder.Entity<SamuraiBattle>()
                        .HasKey(s => new { s.BattleId, s.SamuraiId });

                    //modelBuilder.Entity<Samurai>()
                    //    .Property(s => s.SecretIdentity).IsRequired();
                    base.OnModelCreating(modelBuilder);
                }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
                       .UseSqlServer(
                           "Server=localhost\\SQLEXPRESS;Database=fake-money;Trusted_Connection=True;");
    }
}
