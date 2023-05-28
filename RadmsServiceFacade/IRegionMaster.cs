using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IRegionMaster
    {
        string Save(RegionMasterEntity accident);
        string Update(RegionMasterEntity accident);
        string Delete(int regionId);
        List<RegionMasterEntity> GetAll(string language);
    }
}
