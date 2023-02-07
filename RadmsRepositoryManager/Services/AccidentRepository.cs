using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class AccidentRepository : IAccidentRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(AccidentCauseLookupEntity entity)
        {
            try
            {
                AccidentCauseLookup model = entity.MapToModel<AccidentCauseLookup>();

                context.AccidentCauseLookups.Remove(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AccidentCauseLookupEntity FilterByAccidentName(string CauseName)
        {
            AccidentCauseLookup model = context.AccidentCauseLookups.Where(x => x.AccidentCauseName == CauseName).FirstOrDefault();
            return new AccidentCauseLookupEntity(model);

        }

        //public List<AccidentCauseLookupEntity> FilterByDateRange(DateTime startDate, DateTime endDate)
        //{
        //    List<AccidentCauseLookup> models = context.AccidentCauseLookups.Where(x => x.startDate >= startDate && x.endDate <= endDate).ToList();
        //    List<AccidentCauseLookupEntity> entities = new List<AccidentCauseLookupEntity>();
        //    foreach (var model in models)
        //    {

        //        AccidentCauseLookupEntity entity = new AccidentCauseLookupEntity(model);

        //        entities.Add(entity);
        //    }
        //    return entities;
        //}

        public List<AccidentCauseLookupEntity> GetAll()
        {
            List<AccidentCauseLookup> models = context.AccidentCauseLookups.ToList();
            List<AccidentCauseLookupEntity> entities = new List<AccidentCauseLookupEntity>();
            foreach (var model in models)
            {

                AccidentCauseLookupEntity entity = new AccidentCauseLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public AccidentCauseLookupEntity GetById(int id)
        {
            AccidentCauseLookup model = context.AccidentCauseLookups.Where(x => x.AccidentCauseId == id).FirstOrDefault();
            return new AccidentCauseLookupEntity(model);

        }

        public bool Save(AccidentCauseLookupEntity entity)
        {
            try
            {
                AccidentCauseLookup model = entity.MapToModel<AccidentCauseLookup>();


                context.AccidentCauseLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
     
        }

        public bool Update(AccidentCauseLookupEntity entity)
        {
            try
            {
                AccidentCauseLookup old = context.AccidentCauseLookups.Find(entity.AccidentCauseId);
                old.AccidentCauseId = entity.AccidentCauseId;
                old.AccidentCauseName = entity.AccidentCauseName;
                context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
