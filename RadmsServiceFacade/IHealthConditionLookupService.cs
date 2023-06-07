using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IHealthConditionLookupService
    {
        List<HealthConditionLookupEntity> GetAll(string language);
        string Save(HealthConditionLookupEntity entity);
        string Update(HealthConditionLookupEntity entity);
        string Delete(int healthConditionId);
    }
}
