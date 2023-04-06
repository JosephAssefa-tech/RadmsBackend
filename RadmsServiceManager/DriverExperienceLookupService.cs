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
    public class DriverExperienceLookupService : IDriverExperienceLookupService
    {
        IDriverExperienceLookupRepository _repositiory;
        public DriverExperienceLookupService(IDriverExperienceLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<DriverExperienceLookupEntity> GetAll()
        {
            List<DriverExperienceLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
