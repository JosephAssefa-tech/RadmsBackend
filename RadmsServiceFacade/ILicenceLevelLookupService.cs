using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface ILicenceLevelLookupService
    {
        string Save(LicenceLevelLookupEntity entity);
        string Update(LicenceLevelLookupEntity entity);
        string Delete(int leveloflicenceId);
        List<LicenceLevelLookupEntity> GetAll(string? language);
    }
}
