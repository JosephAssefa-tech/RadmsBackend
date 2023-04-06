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
    public class EducationLevelService : IEducationLevelService
    {
        IEducationLevelRepository _repositiory;
        public EducationLevelService(IEducationLevelRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<EducationLevelLookupEntity> GetAll()
        {
            List<EducationLevelLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
