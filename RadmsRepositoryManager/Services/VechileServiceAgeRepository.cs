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
    public class VechileServiceAgeRepository : IVechileServiceAgeRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int vehicleServiceAgeId)
        {
            try
            {
                var result = context.VehicleServiceAgeLookups.Where(x => x.VehicleServiceAgeId == vehicleServiceAgeId).FirstOrDefault();
                if (result != null)
                {
                    context.VehicleServiceAgeLookups.Remove(result);
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
        public List<VehicleServiceAgeLookupEntity> GetAll(string? language)
        {
            List<VehicleServiceAgeLookup> models;

            if(language == "amharic")
            {
                models 
            = context.VehicleServiceAgeLookups.Select(x=> new VehicleServiceAgeLookup
            {
                VehicleServiceAgeId=x.VehicleServiceAgeId,
                VehicleServiceName=x.VehicleServiceNameAm

            } )
        .ToList();
            }
            else
            {
                models = context.VehicleServiceAgeLookups.Select(x => new VehicleServiceAgeLookup
        {
            VehicleServiceAgeId = x.VehicleServiceAgeId,
            VehicleServiceName = x.VehicleServiceName

        })
         .ToList();

            }
            
        
            List<VehicleServiceAgeLookupEntity> entities = new List<VehicleServiceAgeLookupEntity>();
            foreach (var model in models)
            {

                VehicleServiceAgeLookupEntity entity = new VehicleServiceAgeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(VehicleServiceAgeLookupEntity entity)
        {
            try
            {
                VehicleServiceAgeLookup model = entity.MapToModel<VehicleServiceAgeLookup>();


                context.VehicleServiceAgeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VehicleServiceAgeLookupEntity entity)
        {
            try
            {
                VehicleServiceAgeLookup old = context.VehicleServiceAgeLookups.Find(entity.VehicleServiceAgeId);
                if (old != null)
                {
                    old.VehicleServiceAgeId = entity.VehicleServiceAgeId;
                    old.VehicleServiceName = entity.VehicleServiceName;
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
