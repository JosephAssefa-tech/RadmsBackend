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
    public class RoadSurfaceConditionRepository : IRoadSurfaceConditionRepository
    {
        RadmsContext context = new RadmsContext();
        public List<RoadSurfaceConditionLookupEntity> GetAll()
        {
            List<RoadSurfaceConditionLookup> models = context.RoadSurfaceConditionLookups
             .ToList();
            List<RoadSurfaceConditionLookupEntity> entities = new List<RoadSurfaceConditionLookupEntity>();
            foreach (var model in models)
            {

                RoadSurfaceConditionLookupEntity entity = new RoadSurfaceConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
