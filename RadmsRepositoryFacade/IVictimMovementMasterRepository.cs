using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVictimMovementMasterRepository
    {
        bool Save(VictimMovementMasterEntity entity);
        bool Update(VictimMovementMasterEntity entity);
        bool Delete(int victimMovementId);
        List<VictimMovementMasterEntity> GetAll(string? language);
    }
}
