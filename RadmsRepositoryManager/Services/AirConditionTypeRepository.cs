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
    public class AirConditionTypeRepository : IAirConditionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<AirConditionTypeLookupEntity> GetAll(string language)
        {
            List<AirConditionTypeLookup> models;
            if (language == "amharic")
            {
                models = context.AirConditionTypeLookups.Select(x => new AirConditionTypeLookup
                {
                    AirConditionId = x.AirConditionId,
                    AirConditionName=x.AirConditionNameAm,
                }).ToList();

            }
            else
            {
                models = context.AirConditionTypeLookups.Select(x => new AirConditionTypeLookup
                {
                    AirConditionId = x.AirConditionId,
                    AirConditionName = x.AirConditionName,
                }).ToList();
            }



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
