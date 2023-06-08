using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ICollisionTypeLookupService
    {
        string Save(CollisionTypeLookupEntity entity);
        string Update(CollisionTypeLookupEntity entity);
        string Delete(int collisionTypeId);
        List<CollisionTypeLookupEntity> GetAll(string? language);
    }
}
