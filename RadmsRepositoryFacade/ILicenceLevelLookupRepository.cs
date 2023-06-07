using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ILicenceLevelLookupRepository
    {
        bool Save(LicenceLevelLookupEntity entity);
        bool Update(LicenceLevelLookupEntity entity);
        bool Delete(int leveloflicenceId);
        List<LicenceLevelLookupEntity> GetAll(string? language);
    }
}
