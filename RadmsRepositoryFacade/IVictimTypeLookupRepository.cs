using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IVictimTypeLookupRepository
    {
        bool Save(VictimTypeLookupEntity entity);
        bool Update(VictimTypeLookupEntity entity);
        bool Delete(int victimTypeId);
        List<VictimTypeLookupEntity> GetAll(string? language);
    }
}
