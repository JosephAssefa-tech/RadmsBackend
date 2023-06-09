using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IHighwayMasterService
    {
        string Save(HighwayMasterEntity entity);
        string Update(HighwayMasterEntity entity);
        string Delete(string hid);
        List<HighwayMasterEntity> GetAll(string? language);
    }
}
