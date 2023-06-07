using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ILandmarkTypeRepository
    {
        bool Save(LandmarkTypeLookupEntity entity);
        bool Update(LandmarkTypeLookupEntity entity);
        bool Delete(int landmarkTypeId);
        List<LandmarkTypeLookupEntity> GetAll(string? language);
    }
}
