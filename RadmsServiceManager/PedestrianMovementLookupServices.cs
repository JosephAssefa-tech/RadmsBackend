
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
    public class PedestrianMovementLookupServices : IPedestrianMovementLookupService
    {
        IPedestrianMovementLookupRepository _repositiory;
        public PedestrianMovementLookupServices(IPedestrianMovementLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<PedestrianMovementLookupEntity> GetAll()
        {
            List<PedestrianMovementLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
