using Model.Entities;

namespace DataAccess.DbContexts
{
    public class InvertersRepository : Repository<Inverter>, IInvertersRepository
    {
        public readonly SolarInstalationDbContext _context;

        public InvertersRepository(SolarInstalationDbContext context): base(context)
        {
            _context = context;
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
 
    }
}
