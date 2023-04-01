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
    public class ImpactTypeService : IImpactTypeService
    {
        IImpactTypeRepository _repository;
        public ImpactTypeService(IImpactTypeRepository repository)
        {
            _repository = repository;
        }

        public List<ImpactTypeLookupEntity> GetAll()
        {
            List<ImpactTypeLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
