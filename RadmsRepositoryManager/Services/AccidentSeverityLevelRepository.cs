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
    public class AccidentSeverityLevelRepository : IAccidentSeverityLevelRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int severityId)
        {
            try
            {
                var result = context.SeverityLevelLookups.Where(x => x.SeverityId == severityId).FirstOrDefault();
                if (result != null)
                {
                    context.SeverityLevelLookups.Remove(result);
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

        public List<SeverityLevelLookupEntity> GetAll(string? language)
        {
            List<SeverityLevelLookup> models;


            if (language == "amharic")
            {
                models = context.SeverityLevelLookups.Select(x => new SeverityLevelLookup
                {
                   SeverityId = x.SeverityId,
                   SeverityType = x.SeverityTypeAm
                }).ToList();

            }
            else
            {
                models = context.SeverityLevelLookups.Select(x => new SeverityLevelLookup
                {
                    SeverityId = x.SeverityId,
                    SeverityType = x.SeverityType
                }).ToList();
            }


            List<SeverityLevelLookupEntity> entities = new List<SeverityLevelLookupEntity>();
            foreach (var model in models)
            {

                SeverityLevelLookupEntity entity = new SeverityLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(SeverityLevelLookupEntity entity)
        {
            try
            {
                SeverityLevelLookup model = entity.MapToModel<SeverityLevelLookup>();


                context.SeverityLevelLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(SeverityLevelLookupEntity entity)
        {
            try
            {
                SeverityLevelLookup old = context.SeverityLevelLookups.Find(entity.SeverityId);
                if (old != null)
                {
                    old.SeverityId = entity.SeverityId;
                    old.SeverityType = entity.SeverityType;
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
