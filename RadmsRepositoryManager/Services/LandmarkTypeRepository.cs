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
    public class LandmarkTypeRepository : ILandmarkTypeRepository
    {

        RadmsContext context = new RadmsContext();
        public List<LandmarkTypeLookupEntity> GetAll()
        {
            List<LandmarkTypeLookup> models = context.LandmarkTypeLookups.ToList();
            List<LandmarkTypeLookupEntity> entities = new List<LandmarkTypeLookupEntity>();
            foreach (var model in models)
            {

                LandmarkTypeLookupEntity entity = new LandmarkTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
  
    }
}
