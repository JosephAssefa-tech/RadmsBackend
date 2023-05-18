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
    public class RegionMasterRepository : IRegionMasterRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(decimal id)
        {
            try
            {
                var result = context.RegionMasters.Where(x => x.RegionId == id).FirstOrDefault();
                if (result != null)
                {
                    context.RegionMasters.Remove(result);
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

        public RegionMasterEntity FilterByAccidentName(string name)
        {
            RegionMaster model = context.RegionMasters.Where(x => x.RegionName == name).FirstOrDefault();
            return new RegionMasterEntity(model);
        }

        public List<RegionMasterEntity> GetAll(string language)
        {

            List<RegionMaster> models;
            if (language == "amharic")
            {
               models = context.RegionMasters.Select(x => new RegionMaster
               {
                    RegionId = x.RegionId,
                    RegionName = x.RegionNameAm,
               }).ToList();

            }
            else
            {
                models = context.RegionMasters.Select(x => new RegionMaster
                {
                    RegionId = x.RegionId,
                    RegionName = x.RegionName,
                }).ToList();
            }



                List<RegionMasterEntity> entities = new List<RegionMasterEntity>();
            foreach (var model in models)
            {

                RegionMasterEntity entity = new RegionMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public RegionMasterEntity GetById(int id)
        {
            RegionMaster model = context.RegionMasters.Where(x => x.RegionId == id).FirstOrDefault();
            return new RegionMasterEntity(model);
        }

        public bool Save(RegionMasterEntity entity)
        {
            try
            {
                RegionMaster model = entity.MapToModel<RegionMaster>();


                context.RegionMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(RegionMasterEntity entity)
        {
            try
            {
                RegionMaster old = context.RegionMasters.Find(entity.RegionId);
                if (old != null)
                {
                    old.RegionId = entity.RegionId;
                    old.RegionName = entity.RegionName;
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
