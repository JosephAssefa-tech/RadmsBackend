using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IRoadSurfaceConditionService
    {
        string Save(RoadSurfaceConditionLookupEntity entity);
        string Update(RoadSurfaceConditionLookupEntity entity);
        string Delete(int roadSurfaceId);
        List<RoadSurfaceConditionLookupEntity> GetAll(string? language);
    }
}
