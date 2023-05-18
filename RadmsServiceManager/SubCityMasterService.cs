using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public class SubCityMasterService : ISubCityMasterService
    {
        ISubCityRepository _repository;
        public SubCityMasterService(ISubCityRepository repository)
        {
            _repository = repository;
        }

            public List<SubCityMasterEntity> GetAll(string language)
        {
            List<SubCityMasterEntity> results = this._repository.GetAll(language);
            return results;
        }
    }
}
