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
    public class EmploymentStatusLookupServices : IEmploymentStatusLookupRepository
    {
        RadmsContext context = new RadmsContext();
        List<EmploymentStatusLookupEntity> IEmploymentStatusLookupRepository.GetAll()
        {
            List<EmploymentStatusLookup> models = context.EmploymentStatusLookups
       .ToList();
            List<EmploymentStatusLookupEntity> entities = new List<EmploymentStatusLookupEntity>();
            foreach (var model in models)
            {

                EmploymentStatusLookupEntity entity = new EmploymentStatusLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
