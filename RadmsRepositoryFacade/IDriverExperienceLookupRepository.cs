using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IDriverExperienceLookupRepository
    {
        bool Save(DriverExperienceLookupEntity accident);
        bool Update(DriverExperienceLookupEntity accident);
        bool Delete(int driverExperienceId);
        List<DriverExperienceLookupEntity> GetAll();
    }
}
