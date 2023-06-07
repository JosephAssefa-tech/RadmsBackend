using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IHighWayTypeRepository
    {
        bool Save(HighwayTypeLookupEntity entity);
        bool Update(HighwayTypeLookupEntity entity);
        bool Delete(int htypeId);
        List<HighwayTypeLookupEntity> GetAll(string? language);
    }
}
