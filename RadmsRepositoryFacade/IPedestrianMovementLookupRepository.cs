using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IPedestrianMovementLookupRepository
    {
        bool Save(PedestrianMovementLookupEntity entity);
        bool Update(PedestrianMovementLookupEntity entity);
        bool Delete(int pedestrianMovementId);
        List<PedestrianMovementLookupEntity> GetAll(string? language);
    }
}
