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
    public class CollisionTypeLookupRepository : ICollisionTypeRepository
    {
        public List<CollisionTypeLookupEntity> GetAll(string language)
        {
            RadmsContext context = new RadmsContext();
            List<CollisionTypeLookup> models;
            if (language == "amharic")
            {
                models = context.CollisionTypeLookups.Select(x => new CollisionTypeLookup
                {
                   CollisionTypeId = x.CollisionTypeId,
                   CollisionTypeName = x.CollisionTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.CollisionTypeLookups.Select(x => new CollisionTypeLookup
                {
                    CollisionTypeId = x.CollisionTypeId,
                    CollisionTypeName = x.CollisionTypeName
                }).ToList();
            }


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
