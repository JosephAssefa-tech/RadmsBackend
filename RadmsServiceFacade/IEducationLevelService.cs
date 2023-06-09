using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IEducationLevelService
    {
        string Save(EducationLevelLookupEntity entity);
        string Update(EducationLevelLookupEntity entity);
        string Delete(int educationLevelId);
        List<EducationLevelLookupEntity> GetAll(string? language);
    }
}
