using GitDump.Model;
using Microsoft.EntityFrameworkCore;

namespace GitDump.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Test> TestEntities { get; set; }
       
    }
}
