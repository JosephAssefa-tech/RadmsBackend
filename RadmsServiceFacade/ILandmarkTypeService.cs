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
        List<LandmarkTypeLookupEntity> GetAll();
    }
}
