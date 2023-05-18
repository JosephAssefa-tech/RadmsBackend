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
    public class HighwayMasterService : IHighwayMasterService
    {
        IHighwayMasterRepository _repository;
        public HighwayMasterService(IHighwayMasterRepository repository)
        {
                this._repository = repository;

        }
        public List<HighwayMasterEntity> GetAll(string language)
        {
            List<HighwayMasterEntity> results = this._repository.GetAll(language);
            return results;
        }
    }
}
