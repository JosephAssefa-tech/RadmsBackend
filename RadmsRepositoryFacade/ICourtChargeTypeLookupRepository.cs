using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ICourtChargeTypeLookupRepository
    {
        bool Save(CourtChargeTypeLookupEntity entity);
        bool Update(CourtChargeTypeLookupEntity entity);
        bool Delete(int courtChargeID);
        List<CourtChargeTypeLookupEntity> GetAll(string? language);
    }
}
