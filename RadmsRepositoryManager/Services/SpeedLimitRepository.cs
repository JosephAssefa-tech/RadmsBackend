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
    public class SpeedLimitRepository : ISpeedLimitRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int speedLimitId)
        {
            try
            {
                var result = context.SpeedLimitLookups.Where(x => x.SpeedLimitId == speedLimitId).FirstOrDefault();
                if (result != null)
                {
                    context.SpeedLimitLookups.Remove(result);
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

        public List<SpeedLimitLookupEntity> GetAll(string? language)
    {
            List<SpeedLimitLookup> models;

            if (language == "amharic")
            {
                models = context.SpeedLimitLookups.Select(x => new SpeedLimitLookup
                {
                    SpeedLimitId = x.SpeedLimitId,
                    SpeedLimitName = x.SpeedLimitNameAm,
                }).ToList();

            }
            else
            {
                models = context.SpeedLimitLookups.Select(x => new SpeedLimitLookup
                {
                    SpeedLimitId = x.SpeedLimitId,
                    SpeedLimitName = x.SpeedLimitName,
                }).ToList();
            }



            List<SpeedLimitLookupEntity> entities = new List<SpeedLimitLookupEntity>();
            foreach (var model in models)
            {

                SpeedLimitLookupEntity entity = new SpeedLimitLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(SpeedLimitLookupEntity entity)
        {
            try
            {
                SpeedLimitLookup model = entity.MapToModel<SpeedLimitLookup>();


                context.SpeedLimitLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(SpeedLimitLookupEntity entity)
        {
            try
            {
                SpeedLimitLookup old = context.SpeedLimitLookups.Find(entity.SpeedLimitId);
                if (old != null)
                {
                    old.SpeedLimitId = entity.SpeedLimitId;
                    old.SpeedLimitName = entity.SpeedLimitName;
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
