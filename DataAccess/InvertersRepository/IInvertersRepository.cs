using Model.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.DbContexts
{
    public interface IInvertersRepository : IRepository<Inverter>
    {


        bool SaveAll();


        //public IEnumerable<Inverter> GetInverters(string manufacturer, string searchQuery);

        //public Inverter GetInverter(Guid Id);
    }
}