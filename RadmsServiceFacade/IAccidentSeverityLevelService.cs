using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IAccidentSeverityLevelServicecs
    {
        string Save(SeverityLevelLookupEntity entity);
        string Update(SeverityLevelLookupEntity entity);
        string Delete(int severityId);
        List<SeverityLevelLookupEntity> GetAll(string? language);
    }
}
