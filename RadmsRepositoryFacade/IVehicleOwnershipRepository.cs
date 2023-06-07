using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVehicleOwnershipRepository
    {
        bool Save(VehicleOwnershipLookupEntity entity);
        bool Update(VehicleOwnershipLookupEntity entity);
        bool Delete(int VehicleOwnershipId);
        List<VehicleOwnershipLookupEntity> GetAll(string? language);
    }
}
