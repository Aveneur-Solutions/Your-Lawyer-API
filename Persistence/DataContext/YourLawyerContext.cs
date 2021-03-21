using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models;
using Domain.Models.Messages;
using Domain.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class YourLawyerContext : IdentityDbContext<AppUser>
    {
        public YourLawyerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<AreaOfLaw> AreaOfLaws { get; set; }
        public DbSet<LawyerAndAreaOfLaw> LawyerAndAreaOfLaws { get; set; }
        public DbSet<LawyerEducationalBG> LawyerEducationalBGs { get; set; }
        public DbSet<QueryText> QueryText { get; set; }
        public DbSet<QueryFile> QueryFile { get; set; }
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
              new Division { Id = Guid.NewGuid(), Name = "Mymensingh" },
              new Division { Id = Guid.NewGuid(), Name = "Barisal" },
              new Division { Id = Guid.NewGuid(), Name = "Rangpur" }
          );
            builder.Entity<AreaOfLaw>().HasData(
                new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Banking and Finance Law" },
                new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Civil Litigation" },
                 new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Dispute Resolution" },
                  new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Commercial Law" },
                   new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Construction Law" },
                    new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Corporate Law" },
                     new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Criminal Law" },
                      new AreaOfLaw { Id = Guid.NewGuid(), AreaOfLawName = "Family Law" }
            );

            builder.Entity<QueryText>(x =>
            {
                x.HasOne(x => x.Sender)
                    .WithMany(x => x.SentQueryTexts)
                    .HasForeignKey(x => x.SenderId);

                x.HasOne(x => x.Receiver)
                    .WithMany(x => x.ReceivedQueryTexts)
                    .HasForeignKey(x => x.ReceiverId);
            });

            builder.Entity<QueryFile>(x =>
            {
                x.HasOne(x => x.Sender)
                    .WithMany(x => x.SentQueryFiles)
                    .HasForeignKey(x => x.SenderId);

                x.HasOne(x => x.Receiver)
                    .WithMany(x => x.ReceivedQueryFiles)
                    .HasForeignKey(x => x.ReceiverId);
            });

        }
        
    }
}