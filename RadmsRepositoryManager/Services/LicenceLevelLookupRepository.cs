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
    public class LicenceLevelLookupRepository : ILicenceLevelLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int leveloflicenceId)
        {
            try
            {
                var result = context.LicenceLevelLookups.Where(x => x.LeveloflicenceId == leveloflicenceId).FirstOrDefault();
                if (result != null)
                {
                    context.LicenceLevelLookups.Remove(result);
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
        public List<LicenceLevelLookupEntity> GetAll(string? language)
        {
            List<LicenceLevelLookup> models;
            if(language=="amharic")
            {
                models = context.LicenceLevelLookups.Select(x=> new LicenceLevelLookup
                {
                    LeveloflicenceId=x.LeveloflicenceId,
                    LeveloflicenceName=x.LeveloflicenceNameAm,
                } ) .ToList();
            }
            else
            {
                models = context.LicenceLevelLookups.Select(x => new LicenceLevelLookup
                {
                    LeveloflicenceId = x.LeveloflicenceId,
                    LeveloflicenceName = x.LeveloflicenceName,
                }).ToList();

            }
           
            List<LicenceLevelLookupEntity> entities = new List<LicenceLevelLookupEntity>();
            foreach (var model in models)
            {

                LicenceLevelLookupEntity entity = new LicenceLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(LicenceLevelLookupEntity entity)
        {
            try
            {
                LicenceLevelLookup model = entity.MapToModel<LicenceLevelLookup>();


                context.LicenceLevelLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(LicenceLevelLookupEntity entity)
        {
            try
            {
                LicenceLevelLookup old = context.LicenceLevelLookups.Find(entity.LeveloflicenceId);
                if (old != null)
                {
                    old.LeveloflicenceId = entity.LeveloflicenceId;
                    old.LeveloflicenceName = entity.LeveloflicenceName;
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
