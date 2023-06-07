using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IHighwayMasterRepository
    {
        bool Save(HighwayMasterEntity entity);
        bool Update(HighwayMasterEntity entity);
        bool Delete(string hid);
        List<HighwayMasterEntity> GetAll(string? language);
    }
}
