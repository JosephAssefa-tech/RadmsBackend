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
    public class LandmarkTypeService : ILandmarkTypeService
    {
        public ILandmarkTypeRepository _repository;
        public LandmarkTypeService(ILandmarkTypeRepository repository)
        {
            _repository = repository;
        }
        public List<LandmarkTypeLookupEntity> GetAll(string langugae)
        {
            List<LandmarkTypeLookupEntity> results = this._repository.GetAll(langugae);
            return results;
        }
    }
}
