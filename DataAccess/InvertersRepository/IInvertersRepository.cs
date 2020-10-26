using Model.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.DbContexts
{
    public interface IInvertersRepository : IRepository<Inverter>
    {
        bool SaveAll();
    }
}