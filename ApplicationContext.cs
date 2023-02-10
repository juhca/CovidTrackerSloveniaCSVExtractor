using IndigoLabs2.Models;
using Microsoft.EntityFrameworkCore;

namespace IndigoLabs2
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "IndigoLabsTomas");
        }

        public DbSet<CSVRegionCases> CSVRegions { get; set; }

    }


    //public class ApplicationContext : DbContext
    //{
    //    public ApplicationContext(DbContextOptions options) : base(options) { }
    //    public DbSet<CSVRegionCases> CSVRegions { get; set; }
    //    public DbSet<CSVRegionLastWeek> CSVRegionLastWeeks { get; set; }
    //    public DbSet<User> Users { get; set; }
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    //        SeedData.Seed(modelBuilder);
    //    }


    //}
}
