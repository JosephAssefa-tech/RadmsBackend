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
    public class VehicleDefectRepository : IVehicleDefectRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleDefectLookupEntity> GetAll(string? language)
        {
            List<VehicleDefectLookup> models;
                if(language == "amharic")
            {
                models = context.VehicleDefectLookups.Select(x=> new VehicleDefectLookup
                {
                    VehicleDefectId = x.VehicleDefectId,
                    VehicleDefectName = x.VehicleDefectNameAm,
                }).ToList();
            }
            else
            {
                models = context.VehicleDefectLookups.Select(x => new VehicleDefectLookup
                {
                    VehicleDefectId = x.VehicleDefectId,
                    VehicleDefectName = x.VehicleDefectName,
                }).ToList();

            }
                
              
            List<VehicleDefectLookupEntity> entities = new List<VehicleDefectLookupEntity>();
            foreach (var model in models)
            {

                VehicleDefectLookupEntity entity = new VehicleDefectLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(VehicleDefectLookupEntity entity)
        {
            try
            {
                VehicleDefectLookup model = entity.MapToModel<VehicleDefectLookup>();


                context.VehicleDefectLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VehicleDefectLookupEntity entity)
        {
            try
            {
                VehicleDefectLookup old = context.VehicleDefectLookups.Find(entity.VehicleDefectId);
                if (old != null)
                {
                    old.VehicleDefectId = entity.VehicleDefectId;
                    old.VehicleDefectName = entity.VehicleDefectName;
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
        public bool Delete(int vehicleDefectId)
        {
            try
            {
                var result = context.VehicleDefectLookups.Where(x => x.VehicleDefectId == vehicleDefectId).FirstOrDefault();
                if (result != null)
                {
                    context.VehicleDefectLookups.Remove(result);
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
    }
}
