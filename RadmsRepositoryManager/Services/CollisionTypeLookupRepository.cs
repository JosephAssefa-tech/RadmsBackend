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
    public class CollisionTypeLookupRepository : ICollisionTypeRepository
    {
        public List<CollisionTypeLookupEntity> GetAll()
        {
            RadmsContext context = new RadmsContext();
            List<CollisionTypeLookup> models = context.CollisionTypeLookups.ToList();
            List<CollisionTypeLookupEntity> entities = new List<CollisionTypeLookupEntity>();
            foreach (var model in models)
            {

                CollisionTypeLookupEntity entity = new CollisionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
