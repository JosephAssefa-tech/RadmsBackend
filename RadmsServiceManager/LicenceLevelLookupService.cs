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
    public class LicenceLevelLookupService : ILicenceLevelLookupService
    {
        ILicenceLevelLookupRepository _repositiory;
        public LicenceLevelLookupService(ILicenceLevelLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<LicenceLevelLookupEntity> GetAll()
        {
            List<LicenceLevelLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
