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
        bool Save(PoliceStationMasterEntity accident);
        string Update(PoliceStationMasterEntity accident);
        string Delete(string id);
        List<PoliceStationMasterEntity> GetAll(string language);



    }
}
