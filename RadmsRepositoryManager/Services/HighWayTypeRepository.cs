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
    public class HighWayTypeRepository : IHighWayTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int htypeId)
        {
            try
            {
                var result = context.HighwayTypeLookups.Where(x => x.HtypeId == htypeId).FirstOrDefault();
                if (result != null)
                {
                    context.HighwayTypeLookups.Remove(result);
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

        public List<HighwayTypeLookupEntity> GetAll(string? language)
        {
            List<HighwayTypeLookup> models;
            if (language == "amharic")
            {
                models = context.HighwayTypeLookups.Select(x => new HighwayTypeLookup
                {
                    HtypeId=x.HtypeId,
                    HtypeName=x.HtypeNameAm
                }).ToList();

            }
            else
            {
                models = context.HighwayTypeLookups.Select(x => new HighwayTypeLookup
                {
                    HtypeId = x.HtypeId,
                    HtypeName = x.HtypeName
                }).ToList();
            }


            List<HighwayTypeLookupEntity> entities = new List<HighwayTypeLookupEntity>();
            foreach (var model in models)
            {

                HighwayTypeLookupEntity entity = new HighwayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(HighwayTypeLookupEntity entity)
        {
            try
            {
                HighwayTypeLookup model = entity.MapToModel<HighwayTypeLookup>();


                context.HighwayTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(HighwayTypeLookupEntity entity)
        {
            try
            {
                HighwayTypeLookup old = context.HighwayTypeLookups.Find(entity.HtypeId);
                if (old != null)
                {
                    old.HtypeId = entity.HtypeId;
                    old.HtypeName = entity.HtypeName;
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
