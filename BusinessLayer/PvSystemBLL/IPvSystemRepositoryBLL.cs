using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PvSystemBLL
{
    public interface IPvSystemRepositoryBLL
    {
        void AddEntity(PvSystem model);
        void DeletePvSystem(int id);
        IEnumerable<PvSystem> GetPvSystems();
        PvSystem GetPvSystem(int Id);
        //IEnumerable<Inverter> GetInverters(string manufacturer, string searchQuery);
        bool SaveAll();
        public void AddPvPanelToTheSystem(int pvPanelId, int pvSystemId);
    }
}
