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
    public class LicenceLevelLookupRepository : ILicenceLevelLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<LicenceLevelLookupEntity> GetAll()
        {
            List<LicenceLevelLookup> models = context.LicenceLevelLookups
       .ToList();
            List<LicenceLevelLookupEntity> entities = new List<LicenceLevelLookupEntity>();
            foreach (var model in models)
            {

                LicenceLevelLookupEntity entity = new LicenceLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
