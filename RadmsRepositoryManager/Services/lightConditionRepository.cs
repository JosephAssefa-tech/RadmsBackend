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
    public class lightConditionRepository : IlightConditionRepository
    {
        RadmsContext context = new RadmsContext();
        public List<LightConditionLookupEntity> GetAll()
        {
            List<LightConditionLookup> models = context.LightConditionLookups.
            ToList();
            List<LightConditionLookupEntity> entities = new List<LightConditionLookupEntity>();
            foreach (var model in models)
            {

                LightConditionLookupEntity entity = new LightConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
