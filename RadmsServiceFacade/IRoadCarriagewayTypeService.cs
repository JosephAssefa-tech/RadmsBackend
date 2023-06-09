using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IRoadCarriagewayTypeService
    {
        string Save(RoadCarriagewayTypeLookupEntity entity);
        string Update(RoadCarriagewayTypeLookupEntity entity);
        string Delete(int roadCarriagewayId);
        List<RoadCarriagewayTypeLookupEntity> GetAll(string? lanague);

    }
}
