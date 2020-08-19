using DataAccess.DbContexts;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class InverterRepositoryBLL : IInverterRepositoryBLL
    {
        private readonly IInvertersRepository _repository;
    

        public InverterRepositoryBLL(IInvertersRepository repository)
        {
            _repository = repository;

        }

        public IEnumerable<Inverter> GetAll()
        {
            return _repository.GetAll();
        }

     
        public Inverter GetInverter(int Id)
        {
            return _repository.Get(Id);
        }

        public void AddEntity(Inverter model)
        {
            _repository.Add(model);
            _repository.SaveAll();
        }

        public bool SaveAll()
        {
           
            return _repository.SaveAll();
        }

        public void DeleteInverter(int id)
        {
           var inverter = _repository.Get(id);
            _repository.Remove(inverter);
        }

        public IEnumerable<Inverter> GetInventersWithSpecificPower(double inverterPower)
        {
            return _repository.Find(a => a.MaximumPower==inverterPower);
        }

    }
}

