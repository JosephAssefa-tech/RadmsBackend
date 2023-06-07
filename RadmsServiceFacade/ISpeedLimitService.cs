using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ISpeedLimitService
    {
        string Save(SpeedLimitLookupEntity entity);
        string Update(SpeedLimitLookupEntity entity);
        string Delete(int speedLimitId);
        List<SpeedLimitLookupEntity> GetAll(string language);
    }
}
