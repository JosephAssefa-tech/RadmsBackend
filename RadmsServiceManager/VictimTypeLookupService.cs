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
    public class VictimTypeLookupService : IVictimTypeLookupService
    {
        IVictimTypeLookupRepository _repositiory;
        public VictimTypeLookupService(IVictimTypeLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VictimTypeLookupEntity> GetAll()
        {
            List<VictimTypeLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
