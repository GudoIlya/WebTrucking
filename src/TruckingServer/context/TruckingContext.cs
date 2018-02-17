using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruckingServer.Models;

namespace TruckingServer.context
{
    public class TruckingContext : DbContext
    {       
        public DbSet<Contract> Contracts { get; set; }
              
        public DbSet<Car> Cars { get; set; }

        public DbSet<Cargo> Cargoes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<PositionContract> ContractPositions { get; set; }

        public TruckingContext(DbContextOptions<TruckingContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
        }

    }
}
