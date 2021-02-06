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
       
    }
}