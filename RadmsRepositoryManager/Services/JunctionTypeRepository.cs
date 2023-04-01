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
    public class JunctionTypeRepository : IJunctionTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<JunctionTypeLookupEntity> GetAll()
        {
            List<JunctionTypeLookup> models = context.JunctionTypeLookups.ToList();
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
