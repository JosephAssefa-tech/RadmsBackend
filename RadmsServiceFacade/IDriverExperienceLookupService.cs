using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IDriverExperienceLookupService
    {
        string Save(DriverExperienceLookupEntity entity);
        string Update(DriverExperienceLookupEntity entity);
        string Delete(int driverExperienceId);
        List<DriverExperienceLookupEntity> GetAll(string? language);
    }
}
