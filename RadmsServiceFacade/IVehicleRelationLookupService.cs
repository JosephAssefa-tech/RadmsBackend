using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVehicleRelationLookupService
    {
        string Save(VehicleRelationLookupEntity entity);
        string Update(VehicleRelationLookupEntity entity);
        string Delete(int vehicleRelationId);
        List<VehicleRelationLookupEntity> GetAll(string language);
    }
}
