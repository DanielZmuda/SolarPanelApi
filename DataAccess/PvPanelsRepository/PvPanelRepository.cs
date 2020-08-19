using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DbContexts
{
    public class PvPanelRepository : Repository<PvPanel>, IPvPanelRepository
    {
        private readonly SolarInstalationDbContext _context;

        public PvPanelRepository(SolarInstalationDbContext context) :base(context)
        {
            _context = context;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
