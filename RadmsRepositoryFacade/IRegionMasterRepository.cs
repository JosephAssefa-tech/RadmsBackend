using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IRegionMasterRepository
    {
        bool Save(RegionMasterEntity accident);
        bool Update(RegionMasterEntity accident);
        bool Delete(int regionId);
        List<RegionMasterEntity> GetAll(string language);
        RegionMasterEntity GetById(int id);
        RegionMasterEntity FilterByAccidentName(string CauseName);
    }
}
