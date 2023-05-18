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
        List<AirConditionTypeLookupEntity> GetAll(string languge);
    }
}
