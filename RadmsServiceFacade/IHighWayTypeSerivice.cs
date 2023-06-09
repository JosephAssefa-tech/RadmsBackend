using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IHighWayTypeSerivice
    {
        string Save(HighwayTypeLookupEntity entity);
        string Update(HighwayTypeLookupEntity entity);
        string Delete(int htypeId);
        List<HighwayTypeLookupEntity> GetAll(string? language);
    }
}
