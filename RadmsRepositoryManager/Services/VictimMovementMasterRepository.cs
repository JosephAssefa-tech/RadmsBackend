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
    public class VictimMovementMasterRepository : IVictimMovementMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VictimMovementMasterEntity> GetAll()
        {
            List<VictimMovementMaster> models = context.VictimMovementMasters
      .ToList();
            List<VictimMovementMasterEntity> entities = new List<VictimMovementMasterEntity>();
            foreach (var model in models)
            {

                VictimMovementMasterEntity entity = new VictimMovementMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
