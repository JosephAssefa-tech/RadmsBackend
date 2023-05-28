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
    public class HealthConditionLookupRepository : IHealthConditionLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HealthConditionLookupEntity> GetAll()
        {
            List<HealthConditionLookup> models = context.HealthConditionLookups
      .ToList();
            List<HealthConditionLookupEntity> entities = new List<HealthConditionLookupEntity>();
            foreach (var model in models)
            {

                HealthConditionLookupEntity entity = new HealthConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
