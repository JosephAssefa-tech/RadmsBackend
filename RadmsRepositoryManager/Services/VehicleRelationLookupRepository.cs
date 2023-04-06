using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class VehicleRelationLookupRepository : IVehicleRelationLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleRelationLookupEntity> GetAll()
        {
            List<VehicleRelationLookup> models = context.VehicleRelationLookups
   .ToList();
            List<VehicleRelationLookupEntity> entities = new List<VehicleRelationLookupEntity>();
            foreach (var model in models)
            {

                VehicleRelationLookupEntity entity = new VehicleRelationLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
