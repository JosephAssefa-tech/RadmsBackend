using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IAirConditionTypeService
    {
        string Save(AirConditionTypeLookupEntity entity);
        string Update(AirConditionTypeLookupEntity entity);
        string Delete(int airConditionTypeId);
        List<AirConditionTypeLookupEntity> GetAll(string languge);
    }
}
