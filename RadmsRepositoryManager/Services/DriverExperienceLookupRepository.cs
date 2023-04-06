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
    public class DriverExperienceLookupRepository : IDriverExperienceLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<DriverExperienceLookupEntity> GetAll()
        {
            List<DriverExperienceLookup> models = context.DriverExperienceLookups
          .ToList();
            List<DriverExperienceLookupEntity> entities = new List<DriverExperienceLookupEntity>();
            foreach (var model in models)
            {

                DriverExperienceLookupEntity entity = new DriverExperienceLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
