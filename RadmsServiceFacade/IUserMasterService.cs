using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IUserMasterService
    {
        string Save(UserMasterEntity entity);
        string Update(UserMasterEntity entity);
        string Delete(int userId);
        List<UserMasterEntity> GetAll(string? language);
    }
}
