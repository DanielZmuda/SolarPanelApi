using DataAccess.DbContexts;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.PvSystemRepository
{
    public interface IPvSystemRepository : IRepository<PvSystem>
    {
        bool SaveAll();
    }
}
