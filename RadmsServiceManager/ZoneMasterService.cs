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
    public class ZoneMasterService: IZoneMasterService
    {
        IZoneMasterRepository _repositiory;

        public ZoneMasterService(IZoneMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        List<ZoneMasterEntity> IZoneMasterService.GetAll()
        {
            List<ZoneMasterEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
