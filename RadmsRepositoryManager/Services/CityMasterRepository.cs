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
    public class CityMasterRepository : ICityMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<CityMasterEntity> GetAll()
        {
            List<CityMaster> models = context.CityMasters.
                Include(x => x.Woreda).ThenInclude(z=>z.Zone).ThenInclude(r=>r.Region)
               .ToList();
            List<CityMasterEntity> entities = new List<CityMasterEntity>();
            foreach (var model in models)
            {

                CityMasterEntity entity = new CityMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
