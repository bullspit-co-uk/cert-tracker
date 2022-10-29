using Microsoft.EntityFrameworkCore;

namespace Bullspit.CertTracker.Data.Store
{
    internal class CertContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Sharable;Mode=Memory;Cache=Shared");
        }
    }

}