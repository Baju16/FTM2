using Microsoft.EntityFrameworkCore;
using FTM2.Models;

namespace FTM2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PlayerContract> PlayerContracts { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Team
            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.HasKey(t => t.id);

                entity.HasMany(t => t.Players)
                      .WithOne(p => p.team)
                      .HasForeignKey(p => p.teamid)
                      .OnDelete(DeleteBehavior.SetNull);

                entity.HasMany(t => t.HomeMatches)
                      .WithOne(m => m.hometeam)
                      .HasForeignKey(m => m.hometeamid)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(t => t.AwayMatches)
                      .WithOne(m => m.awayteam)
                      .HasForeignKey(m => m.awayteamid)
                      .OnDelete(DeleteBehavior.Cascade);
            });


            // Player
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("players");
                entity.HasKey(p => p.id);
                entity.HasOne(p => p.PlayerContract)
                      .WithOne(pc => pc.Player)
                      .HasForeignKey<PlayerContract>(pc => pc.playerid)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // PlayerContract
            modelBuilder.Entity<PlayerContract>(entity =>
            {
                entity.ToTable("playercontracts");
                entity.HasKey(pc => pc.id);

                entity.HasIndex(pc => pc.playerid).IsUnique();
            });

            // Match
            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("matches");
                entity.HasKey(m => m.id);
            });

        }
    }
}
