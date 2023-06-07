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
    public class EducationLevelRepository : IEducationLevelRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int educationLevelId)
        {
            try
            {
                var result = context.EducationLevelLookups.Where(x => x.EducationLevelId == educationLevelId).FirstOrDefault();
                if (result != null)
                {
                    context.EducationLevelLookups.Remove(result);
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
        public List<EducationLevelLookupEntity> GetAll(string language)
        {
            List<EducationLevelLookup> models;
            if(language=="amharic")
            {
                models  = context.EducationLevelLookups.Select(x=> new EducationLevelLookup
            {
                EducationLevelId = x.EducationLevelId,
                EducationLevelName = x.EducationLevelNameAm,
            } )
           .ToList();
            }
            else
            {
                models= context.EducationLevelLookups.Select(x => new EducationLevelLookup
         {
             EducationLevelId = x.EducationLevelId,
             EducationLevelName = x.EducationLevelName,
         })
        .ToList();

            }
            
            
            List<EducationLevelLookupEntity> entities = new List<EducationLevelLookupEntity>();
            foreach (var model in models)
            {

                EducationLevelLookupEntity entity = new EducationLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;

        }
        public bool Save(EducationLevelLookupEntity entity)
        {
            try
            {
                EducationLevelLookup model = entity.MapToModel<EducationLevelLookup>();


                context.EducationLevelLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(EducationLevelLookupEntity entity)
        {
            try
            {
                EducationLevelLookup old = context.EducationLevelLookups.Find(entity.EducationLevelId);
                if (old != null)
                {
                    old.EducationLevelId = entity.EducationLevelId;
                    old.EducationLevelName = entity.EducationLevelName;
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
