using Model.Entities;
using System.Collections.Generic;

namespace BusinessLayer.PvSystemBLL
{
    public interface IPvSystemRepositoryBLL
    {
        void AddEntity(PvSystem model);
        void DeletePvSystem(int id);
        IEnumerable<PvSystem> GetPvSystems();
        PvSystem GetPvSystem(int Id);
        bool SaveAll();
        public void AddPvPanelToTheSystem(int pvPanelId, int pvSystemId);
    }
}
