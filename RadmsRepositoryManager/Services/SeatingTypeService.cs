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
    public class SeatingTypeService : ISeatingTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<SeatingTypeLookupEntity> GetAll()
        {
            List<SeatingTypeLookup> models = context.SeatingTypeLookups
         .ToList();
            List<SeatingTypeLookupEntity> entities = new List<SeatingTypeLookupEntity>();
            foreach (var model in models)
            {

                SeatingTypeLookupEntity entity = new SeatingTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
