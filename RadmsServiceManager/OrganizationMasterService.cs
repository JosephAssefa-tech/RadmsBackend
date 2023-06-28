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
    public class OrganizationMasterService : IOrganizationMasterService
    {
        IOrganizationMasterRepository _repository;
        public OrganizationMasterService(IOrganizationMasterRepository repository)
        {
            _repository = repository;
        }
        public List<OrganizationMasterEntity> GetAll(string? language)
        {
            List<OrganizationMasterEntity> results = this._repository.GetAll(language);
            return results;
        }
    }
}
