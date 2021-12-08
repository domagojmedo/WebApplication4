using Microsoft.EntityFrameworkCore;

namespace WebApplication4
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests => Set<Test>();
    }

    public class Test
    {
        public int Id { get; set; }
    }
}
