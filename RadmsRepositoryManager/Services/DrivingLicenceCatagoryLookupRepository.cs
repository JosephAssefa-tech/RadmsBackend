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
    public class DrivingLicenceCatagoryLookupRepository : IDrivingLicenceCatagoryLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public List<DrivingLicenceCatagoryLookupEntity> GetAll()
        {
            List<DrivingLicenceCatagoryLookup> models = context.DrivingLicenceCatagoryLookups
         .ToList();
            List<DrivingLicenceCatagoryLookupEntity> entities = new List<DrivingLicenceCatagoryLookupEntity>();
            foreach (var model in models)
            {

                DrivingLicenceCatagoryLookupEntity entity = new DrivingLicenceCatagoryLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
