using BilgeadamEgitim.Core.Models;
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
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
