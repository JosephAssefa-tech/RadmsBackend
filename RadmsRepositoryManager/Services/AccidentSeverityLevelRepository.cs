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
    public class AccidentSeverityLevelRepository : IAccidentSeverityLevelRepository
    {
        RadmsContext context = new RadmsContext();
        public List<SeverityLevelLookupEntity> GetAll(string language)
        {
            List<SeverityLevelLookup> models;


            if (language == "amharic")
            {
                models = context.SeverityLevelLookups.Select(x => new SeverityLevelLookup
                {
                   SeverityId = x.SeverityId,
                   SeverityType = x.SeverityTypeAm
                }).ToList();

            }
            else
            {
                models = context.SeverityLevelLookups.Select(x => new SeverityLevelLookup
                {
                    SeverityId = x.SeverityId,
                    SeverityType = x.SeverityType
                }).ToList();
            }


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
