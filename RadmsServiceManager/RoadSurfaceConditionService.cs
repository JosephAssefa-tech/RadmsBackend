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
    public class RoadSurfaceConditionService : IRoadSurfaceConditionService
    {
        IRoadSurfaceConditionRepository _repository;
        public RoadSurfaceConditionService(IRoadSurfaceConditionRepository repository)
        {
            _repository = repository;
        }
        public List<RoadSurfaceConditionLookupEntity> GetAll(string language)
        {
            List<RoadSurfaceConditionLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
    }
}
