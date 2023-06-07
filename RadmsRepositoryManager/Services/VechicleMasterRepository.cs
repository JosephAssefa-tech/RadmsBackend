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
    public class VechicleMasterRepository : IVechicleMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VechicleMasterEntity> GetAll(string? language)
        {
            List<VechicleMaster> models;
            if(language == "amharic")
            {
                models = context.VechicleMasters.Select(x=>new VechicleMaster
                {
                    VehicleId = x.VehicleId,
                    VehicleName=x.VehicleNameAm,
                } ).ToList();
            }
            else
            {
                models = context.VechicleMasters.Select(x => new VechicleMaster
                {
                    VehicleId = x.VehicleId,
                    VehicleName = x.VehicleName,
                }).ToList();

            }
                    
            List<VechicleMasterEntity> entities = new List<VechicleMasterEntity>();
            foreach (var model in models)
            {

                VechicleMasterEntity entity = new VechicleMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(VechicleMasterEntity entity)
        {
            try
            {
                VechicleMaster model = entity.MapToModel<VechicleMaster>();


                context.VechicleMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(VechicleMasterEntity entity)
        {
            try
            {
                VechicleMaster old = context.VechicleMasters.Find(entity.VehicleId);
                if (old != null)
                {
                    old.VehicleId = entity.VehicleId;
                    old.VehicleName = entity.VehicleName;
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
        public bool Delete(int VehicleId)
        {
            try
            {
                var result = context.VechicleMasters.Where(x => x.VehicleId == VehicleId).FirstOrDefault();
                if (result != null)
                {
                    context.VechicleMasters.Remove(result);
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
