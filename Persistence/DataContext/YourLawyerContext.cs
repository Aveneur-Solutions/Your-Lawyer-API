using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class YourLawyerContext : DbContext
    {
        public YourLawyerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<AreaOfLaw> AreaOfLaws { get; set; }
        public DbSet<LawyerAndAreaOfLaw> LawyerAndAreaOfLaws { get; set; }
        public DbSet<LawyerEducationalBG> LawyerEducationalBGs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Division>()
          .HasData(
              new Division { Id = Guid.NewGuid(), Name = "Dhaka" },
              new Division { Id = Guid.NewGuid(), Name = "Chittagong" },
              new Division { Id = Guid.NewGuid(), Name = "Rajshahi" },
              new Division { Id = Guid.NewGuid(), Name = "Khulna" },
              new Division { Id = Guid.NewGuid(), Name = "Sylhet" },
              new Division { Id = Guid.NewGuid(), Name = "Comilla" },
              new Division { Id = Guid.NewGuid(), Name = "Barisal" },
              new Division { Id = Guid.NewGuid(), Name = "Rangpur " }
          );
            builder.Entity<AreaOfLaw>().HasData(
                new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Case" },
                new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Criminal" }
            );

        }
    }
}