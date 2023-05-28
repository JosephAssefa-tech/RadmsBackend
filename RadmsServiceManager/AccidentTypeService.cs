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
    public class AccidentTypeService : IAccidentType
    {
        IAccidentTypeRepository _repositiory;
        public AccidentTypeService(IAccidentTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<AccidentTypeLookupEntity> GetAll(string language)
        {
            List<AccidentTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
    }
}
