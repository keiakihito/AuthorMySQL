using Microsoft.EntityFrameworkCore;

namespace AuthorMySQL.Data

{
    public class PubsDbContext : DbContext
    {
        public PubsDbContext(DbContextOptions<PubsDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; } = null!;
    }
}