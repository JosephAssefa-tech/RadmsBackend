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
    public class VehicleOwnershipRepository : IVehicleOwnershipRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int vehicleOwnershipId)
        {
            try
            {
                var result = context.VehicleOwnershipLookups.Where(x => x.VehicleOwnershipId == vehicleOwnershipId).FirstOrDefault();
                if (result != null)
                {
                    context.VehicleOwnershipLookups.Remove(result);
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
        public List<VehicleOwnershipLookupEntity> GetAll(string? language)
        {
            List<VehicleOwnershipLookup> models;
            if(language == "amharic")
            {
                models =context.VehicleOwnershipLookups.Select(x=> new VehicleOwnershipLookup { 
                VehicleOwnershipId = x.VehicleOwnershipId,
                VehicleOwnershipName=x.VehicleOwnershipNameAm
                })
          .ToList();

            }
            else
            {
                models = context.VehicleOwnershipLookups.Select(x => new VehicleOwnershipLookup
                {
                    VehicleOwnershipId = x.VehicleOwnershipId,
                    VehicleOwnershipName = x.VehicleOwnershipName
                })
         .ToList();

            }
            
       
            List<VehicleOwnershipLookupEntity> entities = new List<VehicleOwnershipLookupEntity>();
            foreach (var model in models)
            {

                VehicleOwnershipLookupEntity entity = new VehicleOwnershipLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(VehicleOwnershipLookupEntity entity)
        {
            try
            {
                VehicleOwnershipLookup model = entity.MapToModel<VehicleOwnershipLookup>();


                context.VehicleOwnershipLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VehicleOwnershipLookupEntity entity)
        {
            try
            {
                VehicleOwnershipLookup old = context.VehicleOwnershipLookups.Find(entity.VehicleOwnershipId);
                if (old != null)
                {
                    old.VehicleOwnershipId = entity.VehicleOwnershipId;
                    old.VehicleOwnershipName = entity.VehicleOwnershipName;
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
