using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IRoadCarriagewayTypeRepository
    {
        bool Save(RoadCarriagewayTypeLookupEntity entity);
        bool Update(RoadCarriagewayTypeLookupEntity entity);
        bool Delete(int roadCarriagewayId);
        List<RoadCarriagewayTypeLookupEntity> GetAll(string? lanague);
    }
}
