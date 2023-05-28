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
    public class LandmarkTypeRepository : ILandmarkTypeRepository
    {

        RadmsContext context = new RadmsContext();
        public List<LandmarkTypeLookupEntity> GetAll(string language)
        {
            List<LandmarkTypeLookup> models;

            if (language == "amharic")
            {
                models = context.LandmarkTypeLookups.Select(x => new LandmarkTypeLookup
                {
                    LandmarkName = x.LandmarkNameAm,
                    LandmarkTypeId=x.LandmarkTypeId
                }).ToList();

            }
            else
            {
                models = context.LandmarkTypeLookups.Select(x => new LandmarkTypeLookup
                {
                    LandmarkName = x.LandmarkName,
                    LandmarkTypeId = x.LandmarkTypeId
                }).ToList();
            }


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
