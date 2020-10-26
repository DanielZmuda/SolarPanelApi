using DataAccess.DbContexts;
using Model.Entities;

namespace DataAccess.PvSystemRepository
{
    public interface IPvSystemRepository : IRepository<PvSystem>
    {
        bool SaveAll();
    }
}
