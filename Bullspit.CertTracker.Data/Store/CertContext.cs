using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Bullspit.CertTracker.Data.Store
{
    internal class CertContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? binFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            optionsBuilder.UseSqlite($"Data Source={binFolder}/cert-tracker.db;Cache=Shared");
        }
    }

}