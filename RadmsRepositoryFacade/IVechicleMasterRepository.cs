using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVechicleMasterRepository
    {
        bool Save(VechicleMasterEntity entity);
        bool Update(VechicleMasterEntity entity);
        bool Delete(int vechileId);
        List<VechicleMasterEntity> GetAll(string? language);
    }
}
