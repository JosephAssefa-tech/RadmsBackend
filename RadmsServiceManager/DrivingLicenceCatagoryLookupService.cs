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
    public class DrivingLicenceCatagoryLookupService : IDrivingLicenceCatagoryLookupService
    {
        IDrivingLicenceCatagoryLookupRepository _repositiory;
        public DrivingLicenceCatagoryLookupService(IDrivingLicenceCatagoryLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<DrivingLicenceCatagoryLookupEntity> GetAll()
        {
            List<DrivingLicenceCatagoryLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
