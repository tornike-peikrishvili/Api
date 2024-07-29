using gamocda.Models;
using Microsoft.EntityFrameworkCore;
using gamocda.Models;

namespace gamocda.Data
{
    public class PublishingContext : DbContext
    {
        public PublishingContext(DbContextOptions<PublishingContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Products)
                .WithMany(p => p.Authors)
                .UsingEntity(j => j.ToTable("AuthorProduct"));
        }
    }
}