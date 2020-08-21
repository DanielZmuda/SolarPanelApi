using Model.Entities;
using DataAccess.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLayer.ResourceParameters;

namespace BusinessLayer
{
    public class PvPanelRepositoryBLL : IPvPanelRepositoryBLL
    {
        private readonly IPvPanelRepository _repository;

        public PvPanelRepositoryBLL(IPvPanelRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PvPanel> GetPvPanels()
        {
            return _repository.GetAll();
        }
        public IEnumerable<PvPanel> GetPvPanels(PvPanelResourceParameters pvPanelResourceParameters)
        { 
            if(pvPanelResourceParameters.Power<=0 && string.IsNullOrWhiteSpace(pvPanelResourceParameters.SearchQuery))
            {
                return _repository.GetAll();
            }
            var collection = _repository.GetAll();

            if (!string.IsNullOrWhiteSpace(pvPanelResourceParameters.SearchQuery))
            {
                pvPanelResourceParameters.SearchQuery = pvPanelResourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.Manufacturer.Contains(pvPanelResourceParameters.SearchQuery)
                || a.Name.Contains(pvPanelResourceParameters.SearchQuery)
                || a.Type.Contains(pvPanelResourceParameters.SearchQuery));
            }

            if (pvPanelResourceParameters.Power > 0)
            {
                collection =collection.Where(a => a.Power == pvPanelResourceParameters.Power);
            }

            return collection.ToList();
        }
        
        public PvPanel GetPvPanel(int Id)
        {
            return _repository.Get(Id);
        }

        public void AddEntity(PvPanel model)
        {
            _repository.Add(model);
            _repository.SaveAll();
        }

        public bool SaveAll()
        {
            return _repository.SaveAll();
        }

        public void DeletePvPanel(int id)
        {
            var pvPanel = _repository.Get(id);
            _repository.Remove(pvPanel);
        }

  
    }
}
