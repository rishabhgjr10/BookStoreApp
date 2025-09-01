using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Table for Books
        public DbSet<Book> Books { get; set; }
    }
}
