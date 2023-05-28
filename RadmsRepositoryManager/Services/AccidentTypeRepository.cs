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
    public class AccidentTypeRepository : IAccidentTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<AccidentTypeLookupEntity> GetAll(string language)
        {
            List<AccidentTypeLookup> models;
            if (language == "amharic")
            {
                models = context.AccidentTypeLookups.Select(x => new AccidentTypeLookup
                {
                    AccidentTypeId = x.AccidentTypeId,
                    AccidentType=x.AccidentTypeAm

                  
                }).ToList();

            }
            else
            {
                models = context.AccidentTypeLookups.Select(x => new AccidentTypeLookup
                {
                    AccidentTypeId = x.AccidentTypeId,
                    AccidentType = x.AccidentType
                }).ToList();
            }




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
