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
    public class AirConditionTypeRepository : IAirConditionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int airConditionId)
        {
            try
            {
                var result = context.AirConditionTypeLookups.Where(x => x.AirConditionId == airConditionId).FirstOrDefault();
                if (result != null)
                {
                    context.AirConditionTypeLookups.Remove(result);
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

        public bool Save(AirConditionTypeLookupEntity entity)
        {
            try
            {
                AirConditionTypeLookup model = entity.MapToModel<AirConditionTypeLookup>();


                context.AirConditionTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(AirConditionTypeLookupEntity entity)
        {
            try
            {
                AirConditionTypeLookup old = context.AirConditionTypeLookups.Find(entity.AirConditionId);
                if (old != null)
                {
                    old.AirConditionId = entity.AirConditionId;
                    old.AirConditionName = entity.AirConditionName;
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
        public List<AirConditionTypeLookupEntity> GetAll(string language)
        {
            List<AirConditionTypeLookup> models;
            if (language == "amharic")
            {
                models = context.AirConditionTypeLookups.Select(x => new AirConditionTypeLookup
                {
                    AirConditionId = x.AirConditionId,
                    AirConditionName=x.AirConditionNameAm,
                }).ToList();

            }
            else
            {
                models = context.AirConditionTypeLookups.Select(x => new AirConditionTypeLookup
                {
                    AirConditionId = x.AirConditionId,
                    AirConditionName = x.AirConditionName,
                }).ToList();
            }



            List<AirConditionTypeLookupEntity> entities = new List<AirConditionTypeLookupEntity>();
            foreach (var model in models)
            {

                AirConditionTypeLookupEntity entity = new AirConditionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
