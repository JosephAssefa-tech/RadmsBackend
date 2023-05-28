using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface ICollisionTypeRepository
    {
        List<CollisionTypeLookupEntity> GetAll(string language);
    }
}
