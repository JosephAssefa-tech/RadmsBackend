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
    public class RoadCarriagewayTypeService : IRoadCarriagewayTypeService
    {
        IRoadCarriagewayTypeRepository _repository;
        public RoadCarriagewayTypeService(IRoadCarriagewayTypeRepository repository)
        {
            _repository = repository;
        }

        public List<RoadCarriagewayTypeLookupEntity> GetAll()
        {
            List<RoadCarriagewayTypeLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
