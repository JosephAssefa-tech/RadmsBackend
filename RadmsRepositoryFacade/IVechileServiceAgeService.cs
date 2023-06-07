using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IVechileServiceAgeService
    {
        string Save(VehicleServiceAgeLookupEntity entity);
        string Update(VehicleServiceAgeLookupEntity entity);
        string Delete(int vehicleServiceAgeId);
        List<VehicleServiceAgeLookupEntity> GetAll(string language);
    }
}
