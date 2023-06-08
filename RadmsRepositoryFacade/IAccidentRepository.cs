using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IAccidentRepository
    {
        bool Save(AccidentCauseLookupEntity accident);
        bool Update(AccidentCauseLookupEntity accident);
        bool Delete(decimal id);
        List<AccidentCauseLookupEntity> GetAll(string? language);
        AccidentCauseLookupEntity GetById(int id);
        AccidentCauseLookupEntity FilterByAccidentName(string CauseName);
        // List<AccidentCauseLookupEntity> FilterByDateRange(DateTime startDate, DateTime endDate);




    }
}
