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
    public class VechicleMasterRepository : IVechicleMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<VechicleMasterEntity> GetAll()
        {
            List<VechicleMaster> models = context.VechicleMasters
       .ToList();
            List<VechicleMasterEntity> entities = new List<VechicleMasterEntity>();
            foreach (var model in models)
            {

                VechicleMasterEntity entity = new VechicleMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
