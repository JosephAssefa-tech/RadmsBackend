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
    public class VechicleMasterService : IVechicleMasterService
    {
        IVechicleMasterRepository _repositiory;
        public VechicleMasterService(IVechicleMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VechicleMasterEntity> GetAll()
        {
            List<VechicleMasterEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
