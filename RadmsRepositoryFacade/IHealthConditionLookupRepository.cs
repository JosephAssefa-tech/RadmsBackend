using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IHealthConditionLookupRepository
    {
        List<HealthConditionLookupEntity> GetAll(string language);
        bool Update(HealthConditionLookupEntity entity);
        bool Delete(int healtConditionId);
        bool Save(HealthConditionLookupEntity entity);
    }
}
