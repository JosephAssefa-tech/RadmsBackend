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
        bool Save(CollisionTypeLookupEntity entity);
        bool Update(CollisionTypeLookupEntity entity);
        bool Delete(int collisionTypeId);
        List<CollisionTypeLookupEntity> GetAll(string? language);
    }
}
