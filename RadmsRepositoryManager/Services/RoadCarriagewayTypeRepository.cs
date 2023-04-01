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
    public class RoadCarriagewayTypeRepository : IRoadCarriagewayTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<RoadCarriagewayTypeLookupEntity> GetAll()
        {
            List<RoadCarriagewayTypeLookup> models = context.RoadCarriagewayTypeLookups
               .ToList();
            List<RoadCarriagewayTypeLookupEntity> entities = new List<RoadCarriagewayTypeLookupEntity>();
            foreach (var model in models)
            {

                RoadCarriagewayTypeLookupEntity entity = new RoadCarriagewayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
      
   
    }
}
