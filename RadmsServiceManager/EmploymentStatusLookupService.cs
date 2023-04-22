using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class EmploymentStatusLookupService : IEmploymentStatusLookupService
    {
        IEmploymentStatusLookupRepository _repositiory;
        public EmploymentStatusLookupService(IEmploymentStatusLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<EmploymentStatusLookupEntity> GetAll()
        {
            List<EmploymentStatusLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
