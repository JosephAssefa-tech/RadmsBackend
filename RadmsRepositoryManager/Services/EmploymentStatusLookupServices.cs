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
    public class EmploymentStatusLookupServices : IEmploymentStatusLookupRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int employmentStatusId)
        {
            try
            {
                var result = context.EmploymentStatusLookups.Where(x => x.EmploymentStatusId == employmentStatusId).FirstOrDefault();
                if (result != null)
                {
                    context.EmploymentStatusLookups.Remove(result);
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

        public bool Save(EmploymentStatusLookupEntity entity)
        {
            try
            {
                EmploymentStatusLookup model = entity.MapToModel<EmploymentStatusLookup>();


                context.EmploymentStatusLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(EmploymentStatusLookupEntity entity)
        {
            try
            {
                EmploymentStatusLookup old = context.EmploymentStatusLookups.Find(entity.EmploymentStatusId);
                if (old != null)
                {
                    old.EmploymentStatusId = entity.EmploymentStatusId;
                    old.EmploymentStatusName = entity.EmploymentStatusName;
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

        List<EmploymentStatusLookupEntity> IEmploymentStatusLookupRepository.GetAll(string? language)
        {
            List<EmploymentStatusLookup> models;
           

            if (language == "amharic")
            {
                models = context.EmploymentStatusLookups.Select(x => new EmploymentStatusLookup
                {
                    EmploymentStatusId = x.EmploymentStatusId,
                    EmploymentStatusName = x.EmploymentStatusNameAm,
                }).ToList();

            }
            else
            {
                models = context.EmploymentStatusLookups.Select(x => new EmploymentStatusLookup
                {
                    EmploymentStatusId = x.EmploymentStatusId,
                    EmploymentStatusName = x.EmploymentStatusName,
                }).ToList();
            }


            List<EmploymentStatusLookupEntity> entities = new List<EmploymentStatusLookupEntity>();
            foreach (var model in models)
            {

                EmploymentStatusLookupEntity entity = new EmploymentStatusLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
