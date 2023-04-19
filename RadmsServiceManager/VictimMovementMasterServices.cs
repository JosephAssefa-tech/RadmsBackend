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
    public class VictimMovementMasterServices : IVictimMovementMasterService
    {
        IVictimMovementMasterRepository _repositiory;
        public VictimMovementMasterServices(IVictimMovementMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VictimMovementMasterEntity> GetAll()
        {
            List<VictimMovementMasterEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
