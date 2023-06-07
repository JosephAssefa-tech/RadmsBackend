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
    public class DriverExperienceLookupRepository : IDriverExperienceLookupRepository
    {
        RadmsContext context = new RadmsContext();


        public bool Delete(int driverExperienceId)
        {
            try
            {
                var result = context.DriverExperienceLookups.Where(x => x.DriverExperienceId == driverExperienceId).FirstOrDefault();
                if (result != null)
                {
                    context.DriverExperienceLookups.Remove(result);
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
        public List<DriverExperienceLookupEntity> GetAll(string? language)
        {
            List<DriverExperienceLookup> models;
            if(language == "amharic")
            {
                models = context.DriverExperienceLookups.Select(x => new DriverExperienceLookup
                {
                    DriverExperienceId = x.DriverExperienceId,
                    DriverExperienceName = x.DriverExperienceNameAm,
                }).ToList();

            }
            else
            {
                models = context.DriverExperienceLookups.Select(x => new DriverExperienceLookup
                {
                    DriverExperienceId = x.DriverExperienceId,
                    DriverExperienceName = x.DriverExperienceName,
                }).ToList();

            }
           
            List<DriverExperienceLookupEntity> entities = new List<DriverExperienceLookupEntity>();
            foreach (var model in models)
            {

                DriverExperienceLookupEntity entity = new DriverExperienceLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(DriverExperienceLookupEntity entity)
        {
            try
            {
                DriverExperienceLookup model = entity.MapToModel<DriverExperienceLookup>();


                context.DriverExperienceLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(DriverExperienceLookupEntity entity)
        {
            try
            {
                DriverExperienceLookup old = context.DriverExperienceLookups.Find(entity.DriverExperienceId);
                if (old != null)
                {
                    old.DriverExperienceId = entity.DriverExperienceId;
                    old.DriverExperienceName = entity.DriverExperienceName;
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
