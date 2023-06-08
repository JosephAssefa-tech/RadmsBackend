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
    public class AccidentTypeRepository : IAccidentTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<AccidentTypeLookupEntity> GetAll(string? language)
        {
            List<AccidentTypeLookup> models;
            if (language == "amharic")
            {
                models = context.AccidentTypeLookups.Select(x => new AccidentTypeLookup
                {
                    AccidentTypeId = x.AccidentTypeId,
                    AccidentType = x.AccidentTypeAm


                }).ToList();

            }
            else
            {
                models = context.AccidentTypeLookups.Select(x => new AccidentTypeLookup
                {
                    AccidentTypeId = x.AccidentTypeId,
                    AccidentType = x.AccidentType
                }).ToList();
            }




            List<AccidentTypeLookupEntity> entities = new List<AccidentTypeLookupEntity>();
            foreach (var model in models)
            {

                AccidentTypeLookupEntity entity = new AccidentTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Delete(int accidentTypeId)
        {
            try
            {
                var result = context.AccidentTypeLookups.Where(x => x.AccidentTypeId == accidentTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.AccidentTypeLookups.Remove(result);
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
        public bool Save(AccidentTypeLookupEntity entity)
        {
            try
            {
                AccidentTypeLookup model = entity.MapToModel<AccidentTypeLookup>();


                context.AccidentTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;


            }
        }
        public bool Update(AccidentTypeLookupEntity entity)
        {
            try
            {
                AccidentTypeLookup old = context.AccidentTypeLookups.Find(entity.AccidentTypeId);
                if (old != null)
                {
                    old.AccidentTypeId = entity.AccidentTypeId;
                    old.AccidentType = entity.AccidentType;
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
