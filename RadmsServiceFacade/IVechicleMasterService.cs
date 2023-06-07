using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVechicleMasterService
    {
        string Save(VechicleMasterEntity entity);
        string Update(VechicleMasterEntity entity);
        string Delete(int vehicleId);
        List<VechicleMasterEntity> GetAll(string? language);
    }
}
