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
    public class VechileServiceAgeRepository : IVechileServiceAgeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleServiceAgeLookupEntity> GetAll()
        {
            List<VehicleServiceAgeLookup> models = context.VehicleServiceAgeLookups
        .ToList();
            List<VehicleServiceAgeLookupEntity> entities = new List<VehicleServiceAgeLookupEntity>();
            foreach (var model in models)
            {

                VehicleServiceAgeLookupEntity entity = new VehicleServiceAgeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
