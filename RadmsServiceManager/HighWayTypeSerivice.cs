using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class HighWayTypeSerivice : IHighWayTypeSerivice
    {
        IHighWayTypeRepository _repository;
        public HighWayTypeSerivice(IHighWayTypeRepository repository)
        {
            _repository = repository;
        }
        public List<HighwayTypeLookupEntity> GetAll()
        {
            List<HighwayTypeLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}

