using RadmsEntities;
using RadmsRepositoryFacade.BaseRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IPaymentTypeRepository
    {
        bool Save(PavementTypeLookupEntity entity);
        bool Update(PavementTypeLookupEntity entity);
        bool Delete(int pavementTypeId);
        List<PavementTypeLookupEntity> GetAll(string? language);
    }
}
