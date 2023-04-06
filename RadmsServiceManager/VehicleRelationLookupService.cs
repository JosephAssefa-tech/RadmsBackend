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
    public class VehicleRelationLookupService : IVehicleRelationLookupService
    {
        IVehicleRelationLookupRepository _repositiory;
        public VehicleRelationLookupService(IVehicleRelationLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VehicleRelationLookupEntity> GetAll()
        {
            List<VehicleRelationLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
