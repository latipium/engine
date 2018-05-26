using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Com.Latipium.Engine.Data {
    public class Context : DbContext {
        public DbSet<ContainedStream> ContainedStreams { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Realm> Realms { get; set; }

        public DbSet<Tile> Tiles { get; set; }

        public DbSet<TileEntity> TileEntities { get; set; }

        public DbSet<Universe> Universes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WorldFunction> WorldFunctions { get; set; }

        public DbSet<WorldFunctionPiece> WorldFunctionPieces { get; set; }

        public DbSet<WorldFunctionTerm> WorldFunctionTerms { get; set; }

        public DbSet<WorldObject> WorldObjects { get; set; }

        public DbSet<WorldObjectFilter> WorldObjectFilters { get; set; }

        public DbSet<WorldObjectFilterMapping> WorldObjectFilterMappings { get; set; }

        public DbSet<WorldStream> WorldStreams { get; set; }

        public DbSet<WorldStreamConversion> WorldStreamConversions { get; set; }

        public DbSet<WorldStreamConversionConsumerMapping> WorldStreamConversionConsumerMappings { get; set; }

        public DbSet<WorldStreamConversionExistenceMapping> WorldStreamConversionExistenceMappings { get; set; }

        public DbSet<WorldStreamConversionProducerMapping> WorldStreamConversionProducerMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Tile>().HasIndex(e => e.X);
            modelBuilder.Entity<Tile>().HasIndex(e => e.Y);
            modelBuilder.Entity<Universe>().HasIndex(e => e.Start);
            modelBuilder.Entity<WorldObject>().HasIndex(e => e.ClassName);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            NpgsqlConnectionStringBuilder bldr = new NpgsqlConnectionStringBuilder();
            bldr.ApplicationName = "Latipium Server";
            bldr.Database = Environment.GetEnvironmentVariable("DATABASE_NAME") ?? "Latipium";
            bldr.Host = Environment.GetEnvironmentVariable("DATABASE_HOST") ?? "localhost";
            bldr.Password = Environment.GetEnvironmentVariable("DATABASE_PASS") ?? "root";
            bldr.Username = Environment.GetEnvironmentVariable("DATABASE_USER") ?? "postgres";
            optionsBuilder.UseNpgsql(bldr.ConnectionString);
        }
    }
}
