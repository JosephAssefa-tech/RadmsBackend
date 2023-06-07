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
    public class DrivingLicenceCatagoryLookupRepository : IDrivingLicenceCatagoryLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int drivingLicenceCatagoryId)
        {
            try
            {
                var result = context.DrivingLicenceCatagoryLookups.Where(x => x.DrivingLicenceCatagoryId == drivingLicenceCatagoryId).FirstOrDefault();
                if (result != null)
                {
                    context.DrivingLicenceCatagoryLookups.Remove(result);
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
        public List<DrivingLicenceCatagoryLookupEntity> GetAll(string? language)
        {
            List<DrivingLicenceCatagoryLookup> models;
            if(language=="amharic")
            {
                models = context.DrivingLicenceCatagoryLookups.Select(x=> new DrivingLicenceCatagoryLookup
                {
                    DrivingLicenceCatagoryId=x.DrivingLicenceCatagoryId,
                    DrivingLicenceCatagoryName=x.DrivingLicenceCatagoryNameAm

                }).ToList();

            }
            else
            {
                models = context.DrivingLicenceCatagoryLookups.Select(x => new DrivingLicenceCatagoryLookup
                {
                    DrivingLicenceCatagoryId = x.DrivingLicenceCatagoryId,
                    DrivingLicenceCatagoryName = x.DrivingLicenceCatagoryName

                }).ToList();

            }
       
            List<DrivingLicenceCatagoryLookupEntity> entities = new List<DrivingLicenceCatagoryLookupEntity>();
            foreach (var model in models)
            {

                DrivingLicenceCatagoryLookupEntity entity = new DrivingLicenceCatagoryLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(DrivingLicenceCatagoryLookupEntity entity)
        {
            try
            {
                DrivingLicenceCatagoryLookup model = entity.MapToModel<DrivingLicenceCatagoryLookup>();


                context.DrivingLicenceCatagoryLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(DrivingLicenceCatagoryLookupEntity entity)
        {
            try
            {
                DrivingLicenceCatagoryLookup old = context.DrivingLicenceCatagoryLookups.Find(entity.DrivingLicenceCatagoryId);
                if (old != null)
                {
                    old.DrivingLicenceCatagoryId = entity.DrivingLicenceCatagoryId;
                    old.DrivingLicenceCatagoryName = entity.DrivingLicenceCatagoryName;
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
