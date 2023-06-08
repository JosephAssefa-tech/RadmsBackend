using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IAccidentSeverityLevelRepository
    {
        bool Save(SeverityLevelLookupEntity entity);
        bool Update(SeverityLevelLookupEntity entity);
        bool Delete(int severityId);
        List<SeverityLevelLookupEntity> GetAll(string? language);
    }
}
