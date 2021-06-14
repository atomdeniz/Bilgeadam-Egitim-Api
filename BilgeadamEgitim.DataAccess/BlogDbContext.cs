using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.DataAccess.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BilgeadamEgitim.DataAccess
{

    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
