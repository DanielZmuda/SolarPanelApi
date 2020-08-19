using Model.Entities;
using DataAccess.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;

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
