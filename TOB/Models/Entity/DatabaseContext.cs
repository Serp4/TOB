using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TOB.Models.Game;

namespace TOB.Models.Entity
{
    public class DatabaseContext : DbContext
    {
        public readonly IConfiguration ICongiguration;
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>()
                .Property(b => b.Date)
                .HasDefaultValueSql("NOW()");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DatabaseContext>();

            builder.UseMySql(configuration.GetConnectionString("DefaultConnection"));

            return new DatabaseContext(builder.Options);
        }
    }
}
