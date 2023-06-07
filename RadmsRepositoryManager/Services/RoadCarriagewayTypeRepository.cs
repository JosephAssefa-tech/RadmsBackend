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
    public class RoadCarriagewayTypeRepository : IRoadCarriagewayTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int roadCarriagewayId)
        {
            try
            {
                var result = context.RoadCarriagewayTypeLookups.Where(x => x.RoadCarriagewayId == roadCarriagewayId).FirstOrDefault();
                if (result != null)
                {
                    context.RoadCarriagewayTypeLookups.Remove(result);
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

        public List<RoadCarriagewayTypeLookupEntity> GetAll(string? language)
        {
            List<RoadCarriagewayTypeLookup> models;

            if (language == "amharic")
            {
                models = context.RoadCarriagewayTypeLookups.Select(x => new RoadCarriagewayTypeLookup
                {
                    RoadCarriagewayId = x.RoadCarriagewayId,
                    RoadCarriagewayName = x.RoadCarriagewayNameAm,
                }).ToList();

            }
            else
            {
                models = context.RoadCarriagewayTypeLookups.Select(x => new RoadCarriagewayTypeLookup
                {
                    RoadCarriagewayId = x.RoadCarriagewayId,
                    RoadCarriagewayName = x.RoadCarriagewayName,
                }).ToList();
            }




            List<RoadCarriagewayTypeLookupEntity> entities = new List<RoadCarriagewayTypeLookupEntity>();
            foreach (var model in models)
            {

                RoadCarriagewayTypeLookupEntity entity = new RoadCarriagewayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(RoadCarriagewayTypeLookupEntity entity)
        {
            try
            {
                RoadCarriagewayTypeLookup model = entity.MapToModel<RoadCarriagewayTypeLookup>();


                context.RoadCarriagewayTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(RoadCarriagewayTypeLookupEntity entity)
        {
            try
            {
                RoadCarriagewayTypeLookup old = context.RoadCarriagewayTypeLookups.Find(entity.RoadCarriagewayId);
                if (old != null)
                {
                    old.RoadCarriagewayId = entity.RoadCarriagewayId;
                    old.RoadCarriagewayName = entity.RoadCarriagewayName;
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
