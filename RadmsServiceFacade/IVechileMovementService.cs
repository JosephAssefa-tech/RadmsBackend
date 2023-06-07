using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVechileMovementService
    {
        string Save(VehicleMovementMasterEntity entity);
        string Update(VehicleMovementMasterEntity entity);
        string Delete(int vehicleMovementId);
        List<VehicleMovementMasterEntity> GetAll(string language);
    }
}
