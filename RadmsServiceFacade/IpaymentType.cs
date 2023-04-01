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
        List<PavementTypeLookupEntity> GetAll();
    }
}
