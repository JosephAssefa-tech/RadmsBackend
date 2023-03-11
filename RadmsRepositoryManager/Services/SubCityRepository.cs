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
    public class SubCityRepository : ISubCityRepository
    {
        RadmsContext context = new RadmsContext();
        public List<SubCityMasterEntity> GetAll()
        {
            List<SubCityMaster> models = context.SubCityMasters.
              Include(x => x.City).ThenInclude(r=>r.Woreda).ThenInclude(z=>z.Zone).ThenInclude(r=>r.Region)
             .ToList();
            List<SubCityMasterEntity> entities = new List<SubCityMasterEntity>();
            foreach (var model in models)
            {

                SubCityMasterEntity entity = new SubCityMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
