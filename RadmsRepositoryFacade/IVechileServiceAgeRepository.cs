using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IVechileServiceAgeRepository
    {
        bool Save(VehicleServiceAgeLookupEntity entity);
        bool Update(VehicleServiceAgeLookupEntity entity);
        bool Delete(int vehicleServiceAgeId);
        List<VehicleServiceAgeLookupEntity> GetAll(string? language);
    }
}
