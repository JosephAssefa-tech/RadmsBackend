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
    public class RoadSurfaceConditionRepository : IRoadSurfaceConditionRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int roadSurfaceId)
        {

            try
            {
                var result = context.RoadSurfaceConditionLookups.Where(x => x.RoadSurfaceId == roadSurfaceId).FirstOrDefault();
                if (result != null)
                {
                    context.RoadSurfaceConditionLookups.Remove(result);
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

        public List<RoadSurfaceConditionLookupEntity> GetAll(string language)
        {
            List<RoadSurfaceConditionLookup> models;
            if (language == "amharic")
            {
                models = context.RoadSurfaceConditionLookups.Select(x => new RoadSurfaceConditionLookup
                {
                    RoadSurfaceId = x.RoadSurfaceId,
                    RoadSurfaceName=x.RoadSurfaceNameAm,
                }).ToList();

            }
            else
            {
                models = context.RoadSurfaceConditionLookups.Select(x => new RoadSurfaceConditionLookup
                {
                    RoadSurfaceId = x.RoadSurfaceId,
                    RoadSurfaceName = x.RoadSurfaceName,
                }).ToList();
            }


            List<RoadSurfaceConditionLookupEntity> entities = new List<RoadSurfaceConditionLookupEntity>();
            foreach (var model in models)
            {

                RoadSurfaceConditionLookupEntity entity = new RoadSurfaceConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(RoadSurfaceConditionLookupEntity entity)
        {
            try
            {
                RoadSurfaceConditionLookup model = entity.MapToModel<RoadSurfaceConditionLookup>();


                context.RoadSurfaceConditionLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(RoadSurfaceConditionLookupEntity entity)
        {
            try
            {
                RoadSurfaceConditionLookup old = context.RoadSurfaceConditionLookups.Find(entity.RoadSurfaceId);
                if (old != null)
                {
                    old.RoadSurfaceId = entity.RoadSurfaceId;
                    old.RoadSurfaceName = entity.RoadSurfaceName;
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
