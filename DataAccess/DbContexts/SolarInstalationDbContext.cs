using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DbContexts
{
    public class SolarInstalationDbContext : DbContext
    {
        public SolarInstalationDbContext(DbContextOptions<SolarInstalationDbContext> options) : base(options)
        {

        }
        public DbSet<PvSystem> PvSystem { get; set; }
        public DbSet<PvPanel> PvPanel { get; set; }
        public DbSet<Inverter> Inverter { get; set; }

    }
}
