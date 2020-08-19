using DataAccess.DbContexts;
using DataAccess.PvSystemRepository;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.PvSystemRepository
{
    public class PvSystemRepository : Repository<PvSystem>, IPvSystemRepository
    {
        private readonly SolarInstalationDbContext _context;

        public PvSystemRepository(SolarInstalationDbContext context):base(context)
        {
            _context = context;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

    }
}
