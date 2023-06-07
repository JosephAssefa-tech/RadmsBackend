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
    public class LandmarkTypeRepository : ILandmarkTypeRepository
    {

        RadmsContext context = new RadmsContext();

        public bool Delete(int landmarkTypeId)
        {
            try
            {
                var result = context.LandmarkTypeLookups.Where(x => x.LandmarkTypeId ==landmarkTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.LandmarkTypeLookups.Remove(result);
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

        public List<LandmarkTypeLookupEntity> GetAll(string? language)
        {
            List<LandmarkTypeLookup> models;

            if (language == "amharic")
            {
                models = context.LandmarkTypeLookups.Select(x => new LandmarkTypeLookup
                {
                    LandmarkName = x.LandmarkNameAm,
                    LandmarkTypeId=x.LandmarkTypeId
                }).ToList();

            }
            else
            {
                models = context.LandmarkTypeLookups.Select(x => new LandmarkTypeLookup
                {
                    LandmarkName = x.LandmarkName,
                    LandmarkTypeId = x.LandmarkTypeId
                }).ToList();
            }


            List<LandmarkTypeLookupEntity> entities = new List<LandmarkTypeLookupEntity>();
            foreach (var model in models)
            {

                LandmarkTypeLookupEntity entity = new LandmarkTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(LandmarkTypeLookupEntity entity)
        {
            try
            {
                LandmarkTypeLookup model = entity.MapToModel<LandmarkTypeLookup>();


                context.LandmarkTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(LandmarkTypeLookupEntity entity)
        {
            try
            {
                LandmarkTypeLookup old = context.LandmarkTypeLookups.Find(entity.LandmarkTypeId);
                if (old != null)
                {
                    old.LandmarkTypeId = entity.LandmarkTypeId;
                    old.LandmarkTypeId = entity.LandmarkTypeId;
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
