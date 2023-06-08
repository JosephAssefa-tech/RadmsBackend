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
    public class SeatingTypeService : ISeatingTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int seatingTypeId)
        {
            try
            {
                var result = context.SeatingTypeLookups.Where(x => x.SeatingTypeId == seatingTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.SeatingTypeLookups.Remove(result);
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

        public List<SeatingTypeLookupEntity> GetAll(string? language)
        {
            List<SeatingTypeLookup> models;

            if (language == "amharic")
            {
                models = context.SeatingTypeLookups.Select(x => new SeatingTypeLookup
                {
                    SeatingTypeId = x.SeatingTypeId,
                    SeatingTypeName = x.SeatingTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.SeatingTypeLookups.Select(x => new SeatingTypeLookup
                {
                    SeatingTypeId = x.SeatingTypeId,
                    SeatingTypeName = x.SeatingTypeName,
                }).ToList();
            }


            List<SeatingTypeLookupEntity> entities = new List<SeatingTypeLookupEntity>();
            foreach (var model in models)
            {

                SeatingTypeLookupEntity entity = new SeatingTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(SeatingTypeLookupEntity entity)
        {
            try
            {
                SeatingTypeLookup model = entity.MapToModel<SeatingTypeLookup>();


                context.SeatingTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(SeatingTypeLookupEntity entity)
        {
            try
            {
                SeatingTypeLookup old = context.SeatingTypeLookups.Find(entity.SeatingTypeId);
                if (old != null)
                {
                    old.SeatingTypeId = entity.SeatingTypeId;
                    old.SeatingTypeName = entity.SeatingTypeName;
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
