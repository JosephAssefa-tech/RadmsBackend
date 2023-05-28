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
    public class AirConditionTypeService : IAirConditionTypeService
    {
        IAirConditionTypeRepository _repositiory;
        public AirConditionTypeService(IAirConditionTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<AirConditionTypeLookupEntity> GetAll(string language)
        {
            List<AirConditionTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
    }
}
