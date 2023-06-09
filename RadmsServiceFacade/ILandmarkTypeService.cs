using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ILandmarkTypeService
    {
        string Save(LandmarkTypeLookupEntity entity);
        string Update(LandmarkTypeLookupEntity entity);
        string Delete(int landmarkTypeId);
        List<LandmarkTypeLookupEntity> GetAll(string? language);
    }
}
