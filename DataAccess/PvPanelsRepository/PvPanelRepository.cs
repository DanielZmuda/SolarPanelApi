using Model.Entities;

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
