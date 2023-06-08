using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IAccidentTypeRepository
    {
        bool Save(AccidentTypeLookupEntity entity);
        bool Update(AccidentTypeLookupEntity entity);
        bool Delete(int accidentTypeId);
        List<AccidentTypeLookupEntity> GetAll(string? language);
    }
}
