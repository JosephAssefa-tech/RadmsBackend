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
    public class JunctionTypeService : IJunctionTypeService
    {
        IJunctionTypeRepository _repository;
        public JunctionTypeService(IJunctionTypeRepository repository)
        {
            _repository = repository;
        }
        public List<JunctionTypeLookupEntity> GetAll()
        {
            List<JunctionTypeLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
