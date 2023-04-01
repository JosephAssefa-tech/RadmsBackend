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
    public class HighWayTypeRepository : IHighWayTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HighwayTypeLookupEntity> GetAll()
        {
            List<HighwayTypeLookup> models = context.HighwayTypeLookups.ToList();
            List<HighwayTypeLookupEntity> entities = new List<HighwayTypeLookupEntity>();
            foreach (var model in models)
            {

                HighwayTypeLookupEntity entity = new HighwayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
