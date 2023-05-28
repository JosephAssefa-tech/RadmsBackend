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
    public class JunctionTypeRepository : IJunctionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<JunctionTypeLookupEntity> GetAll(string language)
        {
            List<JunctionTypeLookup> models;

            if (language == "amharic")
            {
                models = context.JunctionTypeLookups.Select(x => new JunctionTypeLookup
                {
                    JunctionTypeId = x.JunctionTypeId,
                    JunctionTypeName = x.JunctionTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.JunctionTypeLookups.Select(x => new JunctionTypeLookup
                {
                    JunctionTypeId = x.JunctionTypeId,
                    JunctionTypeName = x.JunctionTypeName,
                }).ToList();
            }



            List<JunctionTypeLookupEntity> entities = new List<JunctionTypeLookupEntity>();
            foreach (var model in models)
            {

                JunctionTypeLookupEntity entity = new JunctionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
