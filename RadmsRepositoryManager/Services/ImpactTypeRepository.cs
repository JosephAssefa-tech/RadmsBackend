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
    public class ImpactTypeRepository : IImpactTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<ImpactTypeLookupEntity> GetAll()
        {

            List<ImpactTypeLookup> models = context.ImpactTypeLookups.ToList();
            List<ImpactTypeLookupEntity> entities = new List<ImpactTypeLookupEntity>();
            foreach (var model in models)
            {

                ImpactTypeLookupEntity entity = new ImpactTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
       
    }
}
