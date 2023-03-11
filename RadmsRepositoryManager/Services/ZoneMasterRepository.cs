using Microsoft.EntityFrameworkCore;
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
    public class ZoneMasterRepository : IZoneMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<ZoneMasterEntity> GetAll()
        {
            List<ZoneMaster> models = context.ZoneMasters.
                 Include(x => x.Region)

                .ToList();
            List<ZoneMasterEntity> entities = new List<ZoneMasterEntity>();
            foreach (var model in models)
            {

                ZoneMasterEntity entity = new ZoneMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
