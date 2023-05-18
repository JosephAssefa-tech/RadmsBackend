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
    public class VehicleDefectRepository : IVehicleDefectRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleDefectLookupEntity> GetAll()
        {
            List<VehicleDefectLookup> models = context.VehicleDefectLookups
   .ToList();
            List<VehicleDefectLookupEntity> entities = new List<VehicleDefectLookupEntity>();
            foreach (var model in models)
            {

                VehicleDefectLookupEntity entity = new VehicleDefectLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
