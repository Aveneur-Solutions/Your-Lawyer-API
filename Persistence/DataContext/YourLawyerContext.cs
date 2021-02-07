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
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
              builder.Entity<Division>()
            .HasData(
                new Division { Id=Guid.Parse("67752983-6694-4fec-a919-c96aa5a47bbc"),  Name = "Dhaka" },
                new Division { Id=Guid.Parse("cc77b860-7ff2-4ef1-9fb8-c2ed2f3967af"),  Name = "Chittagong" },
                new Division { Id=Guid.Parse("8798ea69-ec65-4813-a5ee-1aad581cb546"),  Name = "Rajshahi" },
                new Division { Id=Guid.Parse("b0d29ac1-74ee-413d-b05f-9e0b1cf74dd2"),  Name = "Khulna" },
                new Division { Id=Guid.Parse("c4571dd4-ca0b-4781-a059-8f17ce0ab2cb"),  Name = "Sylhet" },
                new Division { Id=Guid.Parse("e4db70cb-001d-4776-bf83-586f94385084"),  Name = "Comilla" },
                new Division { Id=Guid.Parse("722f5f32-8398-4912-9f09-99ea57dd5c9e"),  Name = "Barisal" },
                new Division { Id=Guid.Parse("32b7e7c9-d7fa-43b2-93b3-1c025ec2ee3b"),  Name = "Rangpur " }
            );
            builder.Entity<AreaOfLaw>().HasData(
                new AreaOfLaw{Id=Guid.Parse("77b98aad-794b-476d-82ea-4657b6f497e2"),  AreaOfLawName = "Case" },
                new AreaOfLaw{Id=Guid.Parse("1d0da5be-2a5c-4dd9-aad9-98e0054997bc"),  AreaOfLawName = "Criminal" }
            );
            
        }
    }
}