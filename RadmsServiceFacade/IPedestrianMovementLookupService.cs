using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IPedestrianMovementLookupService
    {
        string Save(PedestrianMovementLookupEntity entity);
        string Update(PedestrianMovementLookupEntity entity);
        string Delete(int pedestrianMovementId);
        List<PedestrianMovementLookupEntity> GetAll(string? language);
    }
}
