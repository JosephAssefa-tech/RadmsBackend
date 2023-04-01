using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class TerrainTypeService : ITerrainTypeService
    {
        ITerrianTypeRepository _repository;
        public TerrainTypeService(ITerrianTypeRepository repository)
        {
            _repository = repository;
        }
        public List<TerrainTypeLookupEntity> GetAll()
        {
            List<TerrainTypeLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
