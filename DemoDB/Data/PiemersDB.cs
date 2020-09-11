using DemoDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDB.Data
{
   
    class PiemersDB : DbContext
    {
        
        public DbSet<Piemers> Piemers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DummyDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Piemers>()
                .HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
