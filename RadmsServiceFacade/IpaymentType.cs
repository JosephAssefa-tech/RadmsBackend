using RadmsEntities;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IpaymentType 
    {
        string Save(PavementTypeLookupEntity entity);
        string Update(PavementTypeLookupEntity entity);
        string Delete(int pavementTypeId);
        List<PavementTypeLookupEntity> GetAll(string? language);
    }
}
