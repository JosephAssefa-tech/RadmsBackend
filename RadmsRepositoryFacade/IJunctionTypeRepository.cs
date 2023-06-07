using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IJunctionTypeRepository
    {
        bool Save(JunctionTypeLookupEntity entity);
        bool Update(JunctionTypeLookupEntity entity);
        bool Delete(int junctionTypeId);
        List<JunctionTypeLookupEntity> GetAll(string? language);
    }
}
