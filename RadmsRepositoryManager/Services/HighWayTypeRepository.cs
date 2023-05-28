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
    public class HighWayTypeRepository : IHighWayTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HighwayTypeLookupEntity> GetAll(string language)
        {
            List<HighwayTypeLookup> models;
            if (language == "amharic")
            {
                models = context.HighwayTypeLookups.Select(x => new HighwayTypeLookup
                {
                    HtypeId=x.HtypeId,
                    HtypeName=x.HtypeNameAm
                }).ToList();

            }
            else
            {
                models = context.HighwayTypeLookups.Select(x => new HighwayTypeLookup
                {
                    HtypeId = x.HtypeId,
                    HtypeName = x.HtypeName
                }).ToList();
            }


            List<HighwayTypeLookupEntity> entities = new List<HighwayTypeLookupEntity>();
            foreach (var model in models)
            {

                HighwayTypeLookupEntity entity = new HighwayTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
