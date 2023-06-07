using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IVictimMovementMasterService
    {
        string Save(VictimMovementMasterEntity entity);
        string Update(VictimMovementMasterEntity entity);
        string Delete(int victimMovementId);
        List<VictimMovementMasterEntity> GetAll(string? language);

    }
}
