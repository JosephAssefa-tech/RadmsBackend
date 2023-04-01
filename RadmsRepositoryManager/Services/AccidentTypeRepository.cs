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
    public class AccidentTypeRepository : IAccidentTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<AccidentTypeLookupEntity> GetAll()
        {
            List<AccidentTypeLookup> models = context.AccidentTypeLookups.
             ToList();
            List<AccidentTypeLookupEntity> entities = new List<AccidentTypeLookupEntity>();
            foreach (var model in models)
            {

                AccidentTypeLookupEntity entity = new AccidentTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
   
    }
}
