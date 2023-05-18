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
    public class VictimTypeLookupRepository : IVictimTypeLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VictimTypeLookupEntity> GetAll()
        {
            List<VictimTypeLookup> models = context.VictimTypeLookups
    .ToList();
            List<VictimTypeLookupEntity> entities = new List<VictimTypeLookupEntity>();
            foreach (var model in models)
            {

                VictimTypeLookupEntity entity = new VictimTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
