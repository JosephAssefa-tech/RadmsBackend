using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IAccidentService
    {
        AccidentCauseLookupEntity GetById(int id);
        AccidentCauseLookupEntity FilterByAccidentName(string CauseName);
        // List<AccidentCauseLookupEntity> FilterByDateRange(DateTime startDate, DateTime endDate);
    }
}
