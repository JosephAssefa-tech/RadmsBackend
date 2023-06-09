using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IDrivingLicenceCatagoryLookupService
    {
        string Save(DrivingLicenceCatagoryLookupEntity entity);
        string Update(DrivingLicenceCatagoryLookupEntity entity);
        string Delete(int drivingLicenceCatagoryId);
        List<DrivingLicenceCatagoryLookupEntity> GetAll(string? language);
    }
}
