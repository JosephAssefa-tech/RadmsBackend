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
    public class AirConditionTypeRepository : IAirConditionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<AirConditionTypeLookupEntity> GetAll()
        {
            List<AirConditionTypeLookup> models = context.AirConditionTypeLookups
                .ToList();
            List<AirConditionTypeLookupEntity> entities = new List<AirConditionTypeLookupEntity>();
            foreach (var model in models)
            {

                AirConditionTypeLookupEntity entity = new AirConditionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
