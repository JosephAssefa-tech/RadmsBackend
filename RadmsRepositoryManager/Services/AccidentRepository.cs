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
    public class AccidentRepository : IAccidentRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id )
        {
            try
            {
                var result = context.AccidentCauseLookups.Where(x => x.AccidentCauseId == id).FirstOrDefault();
                if (result != null)
                {
                    context.AccidentCauseLookups.Remove(result);
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
        //public bool UpdatePersonalInfoEmployee(Employee employeeEntity)
        //{
        //    var existingEmp = _context.Employees.Where(e => e.Guid == employeeEntity.Guid).FirstOrDefault();
        //    if (existingEmp == null)
        //        return false;
        //    else
        //    {
        //        // existingEmp.FirstName = employeeEntity.FirstName;
        //        // existingEmp.FatherName = employeeEntity.FatherName;
        //        // existingEmp.GrandFatherName = employeeEntity.GrandFatherName;
        //        existingEmp.FullName = employeeEntity.FullName;

        //        existingEmp.MobilePhone = employeeEntity.MobilePhone;
        //        existingEmp.Phone1 = employeeEntity.Phone1;
        //        existingEmp.Phone2 = employeeEntity.Phone2;

        //        existingEmp.DateofBirth = employeeEntity.DateofBirth;
        //        existingEmp.Gender = employeeEntity.Gender;
        //        existingEmp.Nationality = employeeEntity.Nationality;
        //        existingEmp.PersonalEmail = employeeEntity.PersonalEmail;

        //        existingEmp.PersonalEmail = employeeEntity.PersonalEmail;
        //        existingEmp.PersonalEmail2 = employeeEntity.PersonalEmail2;
        //        existingEmp.PersonalEmail3 = employeeEntity.PersonalEmail3;

        //        _context.SaveChanges(true);

        //    }
        //    return true;
        //}

        public List<AccidentCauseLookupEntity> GetAll(string? language)
        {
            List<AccidentCauseLookup> models;
            if (language == "amharic")
            {
                models = context.AccidentCauseLookups.Select(x => new AccidentCauseLookup
                {
                    AccidentCauseId = x.AccidentCauseId,
                    AccidentCauseName = x.AccidentCauseNameAm
                }).ToList();
            }
            else
            {
                models = context.AccidentCauseLookups.Select(x => new AccidentCauseLookup
                {
                    AccidentCauseId = x.AccidentCauseId,
                    AccidentCauseName = x.AccidentCauseName
                }).ToList();
            }

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
                if(old!=null)
                {
                    old.AccidentCauseId = entity.AccidentCauseId;
                    old.AccidentCauseName = entity.AccidentCauseName;
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
