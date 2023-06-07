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
    public class lightConditionRepository : IlightConditionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int lightConditionId)
        {
            try
            {
                var result = context.LightConditionLookups.Where(x => x.LightConditionId == lightConditionId).FirstOrDefault();
                if (result != null)
                {
                    context.LightConditionLookups.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

                // AccidentCauseLookup model = entity.MapToModel<AccidentCauseLookup>();

                // context.AccidentCauseLookups.Remove(model);
                // context.SaveChanges();
                // return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Save(LightConditionLookupEntity entity)
        {
            try
            {
                LightConditionLookup model = entity.MapToModel<LightConditionLookup>();


                context.LightConditionLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(LightConditionLookupEntity entity)
        {
            try
            {
                LightConditionLookup old = context.LightConditionLookups.Find(entity.LightConditionId);
                if (old != null)
                {
                    old.LightConditionId = entity.LightConditionId;
                    old.LightConditionName = entity.LightConditionName;
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
        public List<LightConditionLookupEntity> GetAll(string language)
        {
            List<LightConditionLookup> models;
            if (language == "amharic")
            {
                models = context.LightConditionLookups.Select(x => new LightConditionLookup
                {
                 LightConditionId = x.LightConditionId,
                 LightConditionName = x.LightConditionNameAm,
                }).ToList();

            }
            else
            {
                models = context.LightConditionLookups.Select(x => new LightConditionLookup
                {
                    LightConditionId = x.LightConditionId,
                    LightConditionName = x.LightConditionName,
                }).ToList();
            }



            List<LightConditionLookupEntity> entities = new List<LightConditionLookupEntity>();
            foreach (var model in models)
            {

                LightConditionLookupEntity entity = new LightConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
