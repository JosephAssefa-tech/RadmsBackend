using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IPoliceStationMaster
    {
        PoliceStationMasterEntity GetById(string id);
        PoliceStationMasterEntity FilterByAccidentName(string CauseName);
        string Save(PoliceStationMasterEntity entity);
        string Update(PoliceStationMasterEntity entity);
        string Delete(string psid);
        List<PoliceStationMasterEntity> GetAll(string? language);



    }
}
