using Microsoft.EntityFrameworkCore;
using AuthorMySQL.Data;
using Xunit;
using System.Threading.Tasks;
using System.Linq;

namespace AuthorMySQL.Tests
{
    public class PubsDbContextTests
    {
        private DbContextOptions<PubsDbContext> GetInMemoryOptions()
        {
            return new DbContextOptionsBuilder<PubsDbContext>()
                .UseInMemoryDatabase(databaseName: "PubsTestDb")
                .Options;
        }

        [Fact]
        public async Task AddAuthor_ShouldAddToDbContext()
        {
            var options = GetInMemoryOptions();

            using (var context = new PubsDbContext(options))
            {
                var author = new Author
                {
                    AuthorId = "999-99-9999",
                    AuthorFirstName = "Testy",
                    AuthorLastName = "McTestFace",
                    Phone = "000-000-0000",
                    Contract = true
                };

                context.Authors.Add(author);
                await context.SaveChangesAsync();
            }

            using (var context = new PubsDbContext(options))
            {
                var author = await context.Authors.FindAsync("999-99-9999");
                Assert.NotNull(author);
                Assert.Equal("Testy", author!.AuthorFirstName);
            }
        }

        [Fact]
        public async Task EditAuthor_ShouldUpdateAuthorDetails()
        {
            var options = GetInMemoryOptions();

            // 初期作成
            using (var context = new PubsDbContext(options))
            {
                context.Authors.Add(new Author
                {
                    AuthorId = "888-88-8888",
                    AuthorFirstName = "Edit",
                    AuthorLastName = "Me",
                    Phone = "111-111-1111",
                    Contract = false
                });
                await context.SaveChangesAsync();
            }

            // 更新処理
            using (var context = new PubsDbContext(options))
            {
                var author = await context.Authors.FindAsync("888-88-8888");
                author!.Phone = "999-999-9999";
                author.Contract = true;
                await context.SaveChangesAsync();
            }

            // 検証
            using (var context = new PubsDbContext(options))
            {
                var author = await context.Authors.FindAsync("888-88-8888");
                Assert.Equal("999-999-9999", author!.Phone);
                Assert.True(author.Contract);
            }
        }
    }
}
