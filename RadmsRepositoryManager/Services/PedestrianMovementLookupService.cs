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
    public class PedestrianMovementLookupService : IPedestrianMovementLookupRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int pedestrianMovementId)
        {
            try
            {
                var result = context.PedestrianMovementLookups.Where(x => x.PedestrianMovementId == pedestrianMovementId).FirstOrDefault();
                if (result != null)
                {
                    context.PedestrianMovementLookups.Remove(result);
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

        public List<PedestrianMovementLookupEntity> GetAll(string? language)
        {
            List<PedestrianMovementLookup> models;

            if (language == "amharic")
            {
                models = context.PedestrianMovementLookups.Select(x => new PedestrianMovementLookup
                {
                    PedestrianMovementId = x.PedestrianMovementId,
                    PedestrianMovementName = x.PedestrianMovementNameAm,
                }).ToList();

            }
            else
            {
                models = context.PedestrianMovementLookups.Select(x => new PedestrianMovementLookup
                {
                    PedestrianMovementId = x.PedestrianMovementId,
                    PedestrianMovementName = x.PedestrianMovementName,
                }).ToList();
            }


            List<PedestrianMovementLookupEntity> entities = new List<PedestrianMovementLookupEntity>();
            foreach (var model in models)
            {

                PedestrianMovementLookupEntity entity = new PedestrianMovementLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(PedestrianMovementLookupEntity entity)
        {
            try
            {
                PedestrianMovementLookup model = entity.MapToModel<PedestrianMovementLookup>();


                context.PedestrianMovementLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(PedestrianMovementLookupEntity entity)
        {
            try
            {
                PedestrianMovementLookup old = context.PedestrianMovementLookups.Find(entity.PedestrianMovementId);
                if (old != null)
                {
                    old.PedestrianMovementId = entity.PedestrianMovementId;
                    old.PedestrianMovementName = entity.PedestrianMovementName;
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
