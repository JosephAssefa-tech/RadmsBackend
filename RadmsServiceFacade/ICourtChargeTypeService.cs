using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ICourtChargeTypeService
    {
        string Save(CourtChargeTypeLookupEntity entity);
        string Update(CourtChargeTypeLookupEntity entity);
        string Delete(int courtChargeID);
        List<CourtChargeTypeLookupEntity> GetAll(string? language);

    }
}
