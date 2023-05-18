using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class VehicleOwnershipRepository : IVehicleOwnershipRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleOwnershipLookupEntity> GetAll()
        {
            List<VehicleOwnershipLookup> models = context.VehicleOwnershipLookups
          .ToList();
            List<VehicleOwnershipLookupEntity> entities = new List<VehicleOwnershipLookupEntity>();
            foreach (var model in models)
            {

                VehicleOwnershipLookupEntity entity = new VehicleOwnershipLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
