using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVehicleDefectService
    {
        string Save(VehicleDefectLookupEntity entity);
        string Update(VehicleDefectLookupEntity entity);
        string Delete(int vehicleDefectId);
        List<VehicleDefectLookupEntity> GetAll(string? language);
    }
}
