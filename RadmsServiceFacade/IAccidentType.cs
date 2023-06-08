using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IAccidentType
    {
        string Save(AccidentTypeLookupEntity entity);
        string Update(AccidentTypeLookupEntity entity);
        string Delete(int accidentTypeId);
        List<AccidentTypeLookupEntity> GetAll(string? language);
    }
}
