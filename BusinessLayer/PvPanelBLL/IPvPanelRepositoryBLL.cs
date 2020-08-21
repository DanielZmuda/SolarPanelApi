using BusinessLayer.ResourceParameters;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IPvPanelRepositoryBLL
    {
        void AddEntity(PvPanel model);
        void DeletePvPanel(int id);
        IEnumerable<PvPanel> GetPvPanels();
        PvPanel GetPvPanel(int Id);

        IEnumerable<PvPanel> GetPvPanels(PvPanelResourceParameters pvPanelResourceParameters);
        //IEnumerable<Inverter> GetInverters(string manufacturer, string searchQuery);
        bool SaveAll();
    }
}
