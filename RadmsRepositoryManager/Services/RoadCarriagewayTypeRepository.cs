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
    public class RoadCarriagewayTypeRepository : IRoadCarriagewayTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<RoadCarriagewayTypeLookupEntity> GetAll(string language)
        {
            List<RoadCarriagewayTypeLookup> models;

            if (language == "amharic")
            {
                models = context.RoadCarriagewayTypeLookups.Select(x => new RoadCarriagewayTypeLookup
                {
                    RoadCarriagewayId = x.RoadCarriagewayId,
                    RoadCarriagewayName = x.RoadCarriagewayNameAm,
                }).ToList();

            }
            else
            {
                models = context.RoadCarriagewayTypeLookups.Select(x => new RoadCarriagewayTypeLookup
                {
                    RoadCarriagewayId = x.RoadCarriagewayId,
                    RoadCarriagewayName = x.RoadCarriagewayName,
                }).ToList();
            }




            List<RoadCarriagewayTypeLookupEntity> entities = new List<RoadCarriagewayTypeLookupEntity>();
            foreach (var model in models)
            {

                RoadCarriagewayTypeLookupEntity entity = new RoadCarriagewayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
      
   
    }
}
