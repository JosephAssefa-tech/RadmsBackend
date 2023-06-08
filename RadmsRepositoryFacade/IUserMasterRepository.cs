using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IUserMasterRepository
    {
        bool Save(UserMasterEntity entity);
        bool Update(UserMasterEntity entity);
        bool Delete(int userId);
        List<UserMasterEntity> GetAll(string? language);
    }
}
