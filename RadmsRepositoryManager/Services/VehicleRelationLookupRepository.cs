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
    public class VehicleRelationLookupRepository : IVehicleRelationLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int vehicleRelationId)
        {
            try
            {
                var result = context.VehicleRelationLookups.Where(x => x.VehicleRelationId == vehicleRelationId).FirstOrDefault();
                if (result != null)
                {
                    context.VehicleRelationLookups.Remove(result);
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
        public List<VehicleRelationLookupEntity> GetAll(string? language)
        {
            List<VehicleRelationLookup> models;
            if(language == "amharic")
            {
                models = context.VehicleRelationLookups.Select(x=> new VehicleRelationLookup
                {
                    VehicleRelationId = x.VehicleRelationId,
                    VehicleRelationName=x.VehicleRelationNameAm
                })
   .ToList();
            }
            else
            {
                models = context.VehicleRelationLookups.Select(x => new VehicleRelationLookup
                {
                    VehicleRelationId = x.VehicleRelationId,
                    VehicleRelationName = x.VehicleRelationName
                })
  .ToList();

            }
            
        
            List<VehicleRelationLookupEntity> entities = new List<VehicleRelationLookupEntity>();
            foreach (var model in models)
            {

                VehicleRelationLookupEntity entity = new VehicleRelationLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(VehicleRelationLookupEntity entity)
        {
            try
            {
                VehicleRelationLookup model = entity.MapToModel<VehicleRelationLookup>();


                context.VehicleRelationLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VehicleRelationLookupEntity entity)
        {
            try
            {
                VehicleRelationLookup old = context.VehicleRelationLookups.Find(entity.VehicleRelationId);
                if (old != null)
                {
                    old.VehicleRelationId = entity.VehicleRelationId;
                    old.VehicleRelationName = entity.VehicleRelationName;
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
