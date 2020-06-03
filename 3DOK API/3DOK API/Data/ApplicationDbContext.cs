using _3DOK_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<GameTable> GameTable { get; set; }
        public virtual DbSet<Game> Game { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<GameTable>()
                .HasOne(gt => gt.Owner)
                .WithMany(gt => gt.OwnedTables)
                .HasForeignKey(gt => gt.OwnerId);

            modelBuilder.Entity<Game>()
                .HasOne(g => g.PlayerOne)
                .WithMany(g => g.PlayedGamesAsPlayerOne)
                .HasForeignKey(g => g.PlayerOneId);
            modelBuilder.Entity<Game>()
                .HasOne(g => g.PlayerTwo)
                .WithMany(g => g.PlayedGamesAsPlayerTwo)
                .HasForeignKey(g => g.PlayerTwoId);
        }
    }
}
