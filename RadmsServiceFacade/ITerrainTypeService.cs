using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface ITerrainTypeService
    {
        string Save(TerrainTypeLookupEntity entity);
        string Update(TerrainTypeLookupEntity entity);
        string Delete(int terrianTypeId);
        List<TerrainTypeLookupEntity> GetAll(string? language);
    }
}
