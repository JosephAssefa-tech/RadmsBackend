using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IEducationLevelRepository
    {
        bool Save(EducationLevelLookupEntity accident);
        bool Update(EducationLevelLookupEntity accident);
        bool Delete(int educationLevelId);
        List<EducationLevelLookupEntity> GetAll(string language);
    }
}
