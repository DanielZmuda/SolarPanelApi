using Model.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IInverterRepositoryBLL
    {
        void AddEntity(Inverter model);
        void DeleteInverter(int id);
        IEnumerable<Inverter> GetAll();
        Inverter GetInverter(int Id);
        //IEnumerable<Inverter> GetInverters(string manufacturer, string searchQuery);
        bool SaveAll();
    }
}