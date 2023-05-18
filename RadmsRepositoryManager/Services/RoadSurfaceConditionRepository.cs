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
    public class RoadSurfaceConditionRepository : IRoadSurfaceConditionRepository
    {
        RadmsContext context = new RadmsContext();
        public List<RoadSurfaceConditionLookupEntity> GetAll(string language)
        {
            List<RoadSurfaceConditionLookup> models;
            if (language == "amharic")
            {
                models = context.RoadSurfaceConditionLookups.Select(x => new RoadSurfaceConditionLookup
                {
                    RoadSurfaceId = x.RoadSurfaceId,
                    RoadSurfaceName=x.RoadSurfaceNameAm,
                }).ToList();

            }
            else
            {
                models = context.RoadSurfaceConditionLookups.Select(x => new RoadSurfaceConditionLookup
                {
                    RoadSurfaceId = x.RoadSurfaceId,
                    RoadSurfaceName = x.RoadSurfaceName,
                }).ToList();
            }


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
