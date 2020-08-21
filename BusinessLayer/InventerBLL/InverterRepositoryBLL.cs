using BusinessLayer.ResourceParameters;
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

        public IEnumerable<Inverter> GetAll(InverterResourceParameters inverterResourceParameters)
        {
            
                if (inverterResourceParameters.MaximumPower == 0 
                    && string.IsNullOrWhiteSpace(inverterResourceParameters.SearchQuery) 
                    && string.IsNullOrWhiteSpace(inverterResourceParameters.Name) 
                    && string.IsNullOrWhiteSpace(inverterResourceParameters.Manufacturer))
                {
                    return _repository.GetAll();
                }

                var collection = _repository.GetAll();

                if (inverterResourceParameters.MaximumPower > 0)
                {
                   collection = collection.Where(a => a.MaximumPower == inverterResourceParameters.MaximumPower);
                }

                if (!string.IsNullOrWhiteSpace(inverterResourceParameters.Name))
                {
                    collection = collection.Where(a => a.Name == inverterResourceParameters.Name);
                }

                if (!string.IsNullOrWhiteSpace(inverterResourceParameters.Manufacturer))
                {
                    collection = collection.Where(a => a.Manufacturer == inverterResourceParameters.Manufacturer);
                }

                if (!string.IsNullOrWhiteSpace(inverterResourceParameters.SearchQuery))
                    {
                inverterResourceParameters.SearchQuery = inverterResourceParameters.SearchQuery.Trim();
                        collection = collection.Where(a => a.Manufacturer.Contains(inverterResourceParameters.SearchQuery)
                        || a.Name.Contains(inverterResourceParameters.SearchQuery));
                    }


            return collection.ToList();
           
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

