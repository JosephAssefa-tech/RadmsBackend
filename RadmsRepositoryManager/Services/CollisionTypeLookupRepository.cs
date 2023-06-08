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
        RadmsContext context = new RadmsContext();
        public bool Delete(int collisionTypeId)
        {
            try
            {
                var result = context.CollisionTypeLookups.Where(x => x.CollisionTypeId == collisionTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.CollisionTypeLookups.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CollisionTypeLookupEntity> GetAll(string? language)
        {
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

        public bool Save(CollisionTypeLookupEntity entity)
        {
            try
            {
                CollisionTypeLookup model = entity.MapToModel<CollisionTypeLookup>();


                context.CollisionTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(CollisionTypeLookupEntity entity)
        {
            try
            {
                CollisionTypeLookup old = context.CollisionTypeLookups.Find(entity.CollisionTypeId);
                if (old != null)
                {
                    old.CollisionTypeId = entity.CollisionTypeId;
                    old.CollisionTypeName = entity.CollisionTypeName;
                    context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();

                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
