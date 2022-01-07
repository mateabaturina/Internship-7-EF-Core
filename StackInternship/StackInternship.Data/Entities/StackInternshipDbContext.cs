using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using StackInternship.Data.Entities.Models;
using StackInternship.Data.Seeds;

namespace StackInternship.Data.Entities
{
    public class StackInternshipDbContext : DbContext
    {
        public StackInternshipDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Resource>()
                .HasOne(c => c.User)
                .WithMany(u => u.Resources)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<Comment>()
                .HasOne(c => c.Resource)
                .WithMany(u => u.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<Answer>()
                .HasOne(a => a.Comment)
                .WithMany(c => c.Answers)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<Answer>()
                .HasOne(a => a.User)
                .WithMany(u => u.Answers)
                .OnDelete(DeleteBehavior.NoAction);

            //DatabaseSeeder.Execute(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class StackInternshipContextFactory : IDesignTimeDbContextFactory<StackInternshipDbContext>
    {
        public StackInternshipDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:StackInternship:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<StackInternshipDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new StackInternshipDbContext(options);
        }
    }
}
