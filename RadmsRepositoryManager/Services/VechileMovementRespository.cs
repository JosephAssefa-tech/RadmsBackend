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
    public class VechileMovementRespository : IVechileMovementRespository
    {
        RadmsContext context = new RadmsContext();
        public List<VehicleMovementMasterEntity> GetAll()
        {
            List<VehicleMovementMaster> models = context.VehicleMovementMasters
        .ToList();
            List<VehicleMovementMasterEntity> entities = new List<VehicleMovementMasterEntity>();
            foreach (var model in models)
            {

                VehicleMovementMasterEntity entity = new VehicleMovementMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
