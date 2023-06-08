using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IImpactTypeRepository
    {
        bool Save(ImpactTypeLookupEntity entity);
        bool Update(ImpactTypeLookupEntity entity);
        bool Delete(int impactTypeId);
        List<ImpactTypeLookupEntity> GetAll(string? language);
    }
}
