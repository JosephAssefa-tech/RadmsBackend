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
    public class SpeedLimitRepository : ISpeedLimitRepository
    {
        RadmsContext context = new RadmsContext();

        public List<SpeedLimitLookupEntity> GetAll(string language)
    {
            List<SpeedLimitLookup> models;

            if (language == "amharic")
            {
                models = context.SpeedLimitLookups.Select(x => new SpeedLimitLookup
                {
                    SpeedLimitId = x.SpeedLimitId,
                    SpeedLimitName = x.SpeedLimitNameAm,
                }).ToList();

            }
            else
            {
                models = context.SpeedLimitLookups.Select(x => new SpeedLimitLookup
                {
                    SpeedLimitId = x.SpeedLimitId,
                    SpeedLimitName = x.SpeedLimitName,
                }).ToList();
            }



            List<SpeedLimitLookupEntity> entities = new List<SpeedLimitLookupEntity>();
            foreach (var model in models)
            {

                SpeedLimitLookupEntity entity = new SpeedLimitLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
