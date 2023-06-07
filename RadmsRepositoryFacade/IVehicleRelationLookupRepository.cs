using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVehicleRelationLookupRepository
    {
        bool Save(VehicleRelationLookupEntity entity);
        bool Update(VehicleRelationLookupEntity entity);
        bool Delete(int vehicleRelationId);
        List<VehicleRelationLookupEntity> GetAll(string? language);

    }
}
