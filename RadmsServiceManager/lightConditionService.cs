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
    public class lightConditionService : IlightConditionService
    {
        IlightConditionRepository _repositiory;
        public lightConditionService(IlightConditionRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<LightConditionLookupEntity> GetAll()
        {
            List<LightConditionLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
