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
    public class SpeedLimitRepository : ISpeedLimitRepository
    {
        RadmsContext context = new RadmsContext();

        public List<SpeedLimitLookupEntity> GetAll()
    {
        List<SpeedLimitLookup> models = context.SpeedLimitLookups.ToList();
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
