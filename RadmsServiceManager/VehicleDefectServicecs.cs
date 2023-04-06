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
    public class VehicleDefectServicecs: IVehicleDefectService
    {
        IVehicleDefectRepository _repositiory;
        public VehicleDefectServicecs(IVehicleDefectRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VehicleDefectLookupEntity> GetAll()
        {
            List<VehicleDefectLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
