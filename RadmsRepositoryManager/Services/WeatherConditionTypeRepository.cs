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
    public class WeatherConditionTypeRepository : IWeatherConditionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int weatherConditionId)
        {
            try
            {
                var result = context.WeatherConditionTypeLookups.Where(x => x.WeatherCondId == weatherConditionId).FirstOrDefault();
                if (result != null)
                {
                    context.WeatherConditionTypeLookups.Remove(result);
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

        public WeatherConditionTypeLookupEntity FilterByAccidentName(string CauseName)
        {
            WeatherConditionTypeLookup model = context.WeatherConditionTypeLookups.Where(x => x.WeatherCondName == CauseName).FirstOrDefault();
            return new WeatherConditionTypeLookupEntity(model);
        }

        public List<WeatherConditionTypeLookupEntity> GetAll(string language)
        {
            List<WeatherConditionTypeLookup> models;

            if (language == "amharic")
            {
                models = context.WeatherConditionTypeLookups.Select(x => new WeatherConditionTypeLookup
                {
                    WeatherCondName = x.WeatherCondNameAm,
                    WeatherCondId = x.WeatherCondId,
                }).ToList();

            } 
            else
            {
                models = context.WeatherConditionTypeLookups.Select(x => new WeatherConditionTypeLookup
                {
                    WeatherCondName = x.WeatherCondName,
                    WeatherCondId = x.WeatherCondId,
                }).ToList();
            }




            List<WeatherConditionTypeLookupEntity> entities = new List<WeatherConditionTypeLookupEntity>();
            foreach (var model in models)
            {

                WeatherConditionTypeLookupEntity entity = new WeatherConditionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public WeatherConditionTypeLookupEntity GetById(int id)
        {
            WeatherConditionTypeLookup model = context.WeatherConditionTypeLookups.Where(x => x.WeatherCondId == id).FirstOrDefault();
            return new WeatherConditionTypeLookupEntity(model);
        }

        public bool Save(WeatherConditionTypeLookupEntity entity)
        {
            try
            {
                WeatherConditionTypeLookup model = entity.MapToModel<WeatherConditionTypeLookup>();


                context.WeatherConditionTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(WeatherConditionTypeLookupEntity entity)
        {
            try
            {
                WeatherConditionTypeLookup old = context.WeatherConditionTypeLookups.Find(entity.WeatherCondId);
                if (old != null)
                {
                    old.WeatherCondId = entity.WeatherCondId;
                    old.WeatherCondName = entity.WeatherCondName;
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
