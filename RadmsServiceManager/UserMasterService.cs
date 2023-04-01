using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class UserMasterService : IUserMasterService
    {
        IUserMasterRepository _repositiory;
        public UserMasterService(IUserMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<UserMasterEntity> GetAll()
        {
            List<UserMasterEntity> results = this._repositiory.GetAll();
            return results;

        }
           

        
    }
}
