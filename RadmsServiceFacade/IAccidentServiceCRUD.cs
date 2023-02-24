using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IAccidentServiceCRUD
    {
        string Save(AccidentCauseLookupEntity accident);
        string Update(AccidentCauseLookupEntity accident);
        string Delete(decimal id );
        List<AccidentCauseLookupEntity> GetAll();
    }
}
