using Microsoft.EntityFrameworkCore;
using SampleBookStore.Models;

namespace SampleBookStore.Data {
    public class SampleBookStoreContext : DbContext
    {
        public SampleBookStoreContext (DbContextOptions<SampleBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Book>().ToTable("Book");
        }
    }
}
