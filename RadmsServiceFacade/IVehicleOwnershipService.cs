using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IVehicleOwnershipService
    {
        string Save(VehicleOwnershipLookupEntity entity);
        string Update(VehicleOwnershipLookupEntity entity);
        string Delete(int vehicleOwnershipId);
        List<VehicleOwnershipLookupEntity> GetAll(string language);
    }
}
