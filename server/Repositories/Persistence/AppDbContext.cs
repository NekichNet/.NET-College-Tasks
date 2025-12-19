using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using server.Models;
using server.Repositories.Persistence.Configurations;

namespace server.Repositories.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /* до лучших времён
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        */
    }
}
