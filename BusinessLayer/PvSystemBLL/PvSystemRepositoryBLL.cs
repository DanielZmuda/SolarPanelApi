using DataAccess.DbContexts;
using DataAccess.PvSystemRepository;
using Model.Entities;
using System.Collections.Generic;

namespace BusinessLayer.PvSystemBLL
{
   public class PvSystemRepositoryBLL : IPvSystemRepositoryBLL
    {
        private readonly IPvSystemRepository _repository;
        private readonly IPvPanelRepository _pvPanelRepository;

        public PvSystemRepositoryBLL(IPvSystemRepository repository, IPvPanelRepository pvPanelRepository)
        {
            _repository = repository;
            _pvPanelRepository = pvPanelRepository;
        }

        public void AddPvPanelToTheSystem(int Id, int pvPanelId)
        { 

        }

        public IEnumerable<PvSystem> GetPvSystems()
        {
            return _repository.GetAll();
        }

        public PvSystem GetPvSystem(int Id)
        {
            return _repository.Get(Id);
        }

        public void AddEntity(PvSystem model)
        {
            _repository.Add(model);
            _repository.SaveAll();
        }

        public bool SaveAll()
        {

            return _repository.SaveAll();
        }

        public void DeletePvSystem(int id)
        {
            var model = _repository.Get(id);
            _repository.Remove(model);
        }

  



    }
}
