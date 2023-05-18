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
    public class CollisionTypeService : ICollisionTypeLookupService
    {
        ICollisionTypeRepository _repositiory;
        public CollisionTypeService(ICollisionTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<CollisionTypeLookupEntity> GetAll(string language)
        {
            List<CollisionTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
    }
}
