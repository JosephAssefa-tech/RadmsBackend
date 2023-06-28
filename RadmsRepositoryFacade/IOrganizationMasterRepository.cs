using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IOrganizationMasterRepository
    {
        List<OrganizationMasterEntity> GetAll(string? language);
    }
}
