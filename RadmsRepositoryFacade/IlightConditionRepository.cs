using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IlightConditionRepository
    {
        bool Save(LightConditionLookupEntity entity);
        bool Update(LightConditionLookupEntity entity);
        bool Delete(int lightConditionId);
        List<LightConditionLookupEntity> GetAll(string language);
    }
}
