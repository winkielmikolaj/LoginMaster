using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaster
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=LoginMaster;Username=postgres;Password=1234");
        }
    }
}
