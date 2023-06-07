using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IAirConditionTypeRepository
    {
        bool Save(AirConditionTypeLookupEntity entity);
        bool Update(AirConditionTypeLookupEntity entity);
        bool Delete(int airConditionId);
        List<AirConditionTypeLookupEntity> GetAll(string language);
    }
}
