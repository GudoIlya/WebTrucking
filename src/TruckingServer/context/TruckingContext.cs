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
        public TruckingContext(DbContextOptions<TruckingContext> options) : base(options)
        { }
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Car> Car { get; set; }

        public DbSet<Cargo> Cargoes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<PositionContract> PositionContract { get; set; }

    }
}
