using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IJunctionTypeService
    {
        string Save(JunctionTypeLookupEntity entity);
        string Update(JunctionTypeLookupEntity entity);
        string Delete(int junctionTypeId);
        List<JunctionTypeLookupEntity> GetAll(string? language);
    }
}
