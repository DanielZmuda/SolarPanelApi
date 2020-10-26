using Model.Entities;

namespace DataAccess.DbContexts
{
    public interface IPvPanelRepository : IRepository<PvPanel>
    {
        bool SaveAll();
    }
}
