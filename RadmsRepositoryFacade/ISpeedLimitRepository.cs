using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface ISpeedLimitRepository
    {
        bool Save(SpeedLimitLookupEntity entity);
        bool Update(SpeedLimitLookupEntity entity);
        bool Delete(int speedLimitId);
        List<SpeedLimitLookupEntity> GetAll(string? language);

    }
}
