using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IlightConditionService
    {
        string Save(LightConditionLookupEntity entity);
        string Update(LightConditionLookupEntity entity);
        string Delete(int lightConditionId);
        List<LightConditionLookupEntity> GetAll(string language);
    }
}
