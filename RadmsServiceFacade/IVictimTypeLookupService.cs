using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IVictimTypeLookupService
    {
        string Save(VictimTypeLookupEntity entity);
        string Update(VictimTypeLookupEntity entity);
        string Delete(int victimTypeId);
        List<VictimTypeLookupEntity> GetAll(string? language);
    }
}
