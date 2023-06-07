using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IDrivingLicenceCatagoryLookupRepository
    {
        bool Save(DrivingLicenceCatagoryLookupEntity accident);
        bool Update(DrivingLicenceCatagoryLookupEntity accident);
        bool Delete(int drivingLicenceCatagoryId);
        List<DrivingLicenceCatagoryLookupEntity> GetAll(string? language);
    }
}
