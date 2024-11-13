using DemoDB.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDB.Data
{

    public class ExampleContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            try
            {
                options.UseSqlServer("Server=JS\\SQLEXPRESS;Database=DummyDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            }
            catch (System.Exception)
            {
                throw;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Example>()
                .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
