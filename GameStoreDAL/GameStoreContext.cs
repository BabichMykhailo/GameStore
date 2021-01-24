using GameStoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDAL
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext() : base("name = DefaultConnection")
        {

        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                 .HasRequired(x => x.Developer)
                 .WithMany(x => x.Games);

            modelBuilder.Entity<Game>()
                .HasRequired(x => x.Publisher)
                .WithMany(x => x.Games);

            modelBuilder.Entity<Game>()
                .HasMany(x => x.Genres)
                .WithMany(x => x.Games);

            modelBuilder.Entity<Game>()
                .HasMany(x => x.Orders)
                .WithMany(x => x.Games);

        }
    }
}
