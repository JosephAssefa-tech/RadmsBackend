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
    public class VechileMovementRespository : IVechileMovementRespository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleMovementMasterEntity> GetAll(string? language)
        {
            List<VehicleMovementMaster> models;
            if(language == "amharic")
            {
                models = context.VehicleMovementMasters.Select(x=> new VehicleMovementMaster
                {
                    VehicleMovementId=x.VehicleMovementId,
                    VehicleMovementMasterName=x.VehicleMovementMasterNameAm,
                } )
        .ToList();

            }
            else
            {
                models = context.VehicleMovementMasters.Select(x => new VehicleMovementMaster
                {
                    VehicleMovementId = x.VehicleMovementId,
                    VehicleMovementMasterName = x.VehicleMovementMasterName,
                })
       .ToList();

            }
            
        
            List<VehicleMovementMasterEntity> entities = new List<VehicleMovementMasterEntity>();
            foreach (var model in models)
            {

                VehicleMovementMasterEntity entity = new VehicleMovementMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(VehicleMovementMasterEntity entity)
        {
            try
            {
                VehicleMovementMaster model = entity.MapToModel<VehicleMovementMaster>();


                context.VehicleMovementMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VehicleMovementMasterEntity entity)
        {
            try
            {
                VehicleMovementMaster old = context.VehicleMovementMasters.Find(entity.VehicleMovementId);
                if (old != null)
                {
                    old.VehicleMovementId = entity.VehicleMovementId;
                    old.VehicleMovementMasterName = entity.VehicleMovementMasterName;
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
        public bool Delete(int vehicleMovementId)
        {
            try
            {
                var result = context.VehicleMovementMasters.Where(x => x.VehicleMovementId == vehicleMovementId).FirstOrDefault();
                if (result != null)
                {
                    context.VehicleMovementMasters.Remove(result);
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
