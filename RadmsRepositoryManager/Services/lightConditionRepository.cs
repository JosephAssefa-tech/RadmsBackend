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
    public class lightConditionRepository : IlightConditionRepository
    {
        RadmsContext context = new RadmsContext();
        public List<LightConditionLookupEntity> GetAll(string language)
        {
            List<LightConditionLookup> models;
            if (language == "amharic")
            {
                models = context.LightConditionLookups.Select(x => new LightConditionLookup
                {
                 LightConditionId = x.LightConditionId,
                 LightConditionName = x.LightConditionNameAm,
                }).ToList();

            }
            else
            {
                models = context.LightConditionLookups.Select(x => new LightConditionLookup
                {
                    LightConditionId = x.LightConditionId,
                    LightConditionName = x.LightConditionName,
                }).ToList();
            }



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
