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
    public class EducationLevelRepository : IEducationLevelRepository
    {
        RadmsContext context = new RadmsContext();
        public List<EducationLevelLookupEntity> GetAll()
        {
                List<EducationLevelLookup> models = context.EducationLevelLookups
           .ToList();
            List<EducationLevelLookupEntity> entities = new List<EducationLevelLookupEntity>();
            foreach (var model in models)
            {

                EducationLevelLookupEntity entity = new EducationLevelLookupEntity(model);

                entities.Add(entity);
            }
            return entities;

        }
    }
}
