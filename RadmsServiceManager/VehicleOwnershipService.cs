using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;

namespace RadmsServiceManager
{
    public class VehicleOwnershipService : IVehicleOwnershipService
    {
        IVehicleOwnershipRepository _repositiory;
        public VehicleOwnershipService(IVehicleOwnershipRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VehicleOwnershipLookupEntity> GetAll()
        {
            List<VehicleOwnershipLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
