using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IPoliceStationMasterRepository
    {
        bool Save(PoliceStationMasterEntity entity);
        bool Update(PoliceStationMasterEntity entity);
        bool Delete(string id);
        List<PoliceStationMasterEntity> GetAll(string language);
        PoliceStationMasterEntity GetById(string id);
        PoliceStationMasterEntity FilterByAccidentName(string CauseName);
    }
}
