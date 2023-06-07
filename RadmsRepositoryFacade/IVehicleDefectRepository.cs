using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVehicleDefectRepository
    {
        bool Save(VehicleDefectLookupEntity accident);
        bool Update(VehicleDefectLookupEntity accident);
        bool Delete(int vehicleDefectId);
        List<VehicleDefectLookupEntity> GetAll(string? language);
    }
}
