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
    public class AccidentSeverityLevelRepository : IAccidentSeverityLevelRepository
    {
        RadmsContext context = new RadmsContext();
        public List<SeverityLevelLookupEntity> GetAll()
        {
            List<SeverityLevelLookup> models = context.SeverityLevelLookups.
         ToList();
            List<SeverityLevelLookupEntity> entities = new List<SeverityLevelLookupEntity>();
            foreach (var model in models)
            {

                SeverityLevelLookupEntity entity = new SeverityLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
