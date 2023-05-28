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
    public class PedestrianMovementLookupService : IPedestrianMovementLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<PedestrianMovementLookupEntity> GetAll()
        {
            List<PedestrianMovementLookup> models = context.PedestrianMovementLookups
       .ToList();
            List<PedestrianMovementLookupEntity> entities = new List<PedestrianMovementLookupEntity>();
            foreach (var model in models)
            {

                PedestrianMovementLookupEntity entity = new PedestrianMovementLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
