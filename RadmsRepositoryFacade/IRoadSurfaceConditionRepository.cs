using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IRoadSurfaceConditionRepository
    {
        bool Save(RoadSurfaceConditionLookupEntity entity);
        bool Update(RoadSurfaceConditionLookupEntity entity);
        bool Delete(int roadSurfaceId);
        List<RoadSurfaceConditionLookupEntity> GetAll(string? language);

    }
}
