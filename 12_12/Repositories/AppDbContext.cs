using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_12.Model;
using Microsoft.EntityFrameworkCore;

namespace _12_12.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Store;Username=postgres;Password=1;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
