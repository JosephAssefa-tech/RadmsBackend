using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IImpactTypeService
    {
        string Save(ImpactTypeLookupEntity entity);
        string Update(ImpactTypeLookupEntity entity);
        string Delete(int impactTypeId);
        List<ImpactTypeLookupEntity> GetAll(string? language);
    }
}
