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
    public class HealthConditionLookupRepository : IHealthConditionLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HealthConditionLookupEntity> GetAll(string language)
        {
            List<HealthConditionLookup> models;
            if (language == "amharic")
            {
            models= context.HealthConditionLookups.Select(x=>new HealthConditionLookup
            {
                HealthConditionId = x.HealthConditionId,
                HealthConditionName = x.HealthConditionNameAm,
            }).ToList();
            }
           else {
                models = context.HealthConditionLookups.Select(x => new HealthConditionLookup
                {
                    HealthConditionId = x.HealthConditionId,
                    HealthConditionName = x.HealthConditionName,
                }).ToList();

            }

            List<HealthConditionLookupEntity> entities = new List<HealthConditionLookupEntity>();
            foreach (var model in models)
            {

                HealthConditionLookupEntity entity = new HealthConditionLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Update(HealthConditionLookupEntity entity)
        {
            try
            {
                HealthConditionLookup old = context.HealthConditionLookups.Find(entity.HealthConditionId);
                if (old != null)
                {
                    old.HealthConditionId = entity.HealthConditionId;
                    old.HealthConditionName = entity.HealthConditionName;
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
        public bool Delete(int healthconditionId)
        {
            try
            {
                var result = context.HealthConditionLookups.Where(x => x.HealthConditionId == healthconditionId).FirstOrDefault();
                if (result != null)
                {
                    context.HealthConditionLookups.Remove(result);
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


        public bool Save(HealthConditionLookupEntity entity)
        {
            try
            {
                HealthConditionLookup model = entity.MapToModel<HealthConditionLookup>();


                context.HealthConditionLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
