using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class VechileServiceAgeService : IVechileServiceAgeService
    {
        IVechileServiceAgeRepository _repositiory;
        public VechileServiceAgeService(IVechileServiceAgeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VehicleServiceAgeLookupEntity> GetAll()
        {
            List<VehicleServiceAgeLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
