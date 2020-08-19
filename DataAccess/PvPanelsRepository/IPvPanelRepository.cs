using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DbContexts
{
    public interface IPvPanelRepository : IRepository<PvPanel>
    {

        bool SaveAll();
    }
}
