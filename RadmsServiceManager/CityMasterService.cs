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
    public class CityMasterService : ICityMasterService
    {
        ICityMasterRepository _repositiory;
        public CityMasterService(ICityMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }

        List<CityMasterEntity> ICityMasterService.GetAll(string language)
        {
            List<CityMasterEntity> results = this._repositiory.GetAll( language);
            return results;
        }
    }
}
