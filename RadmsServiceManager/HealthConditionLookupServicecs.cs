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
    public class HealthConditionLookupServicecs : IHealthConditionLookupService
    {
        IHealthConditionLookupRepository _repository;
        public HealthConditionLookupServicecs(IHealthConditionLookupRepository repository)
        {
            _repository = repository;
        }
        public List<HealthConditionLookupEntity> GetAll()
        {
            List<HealthConditionLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
