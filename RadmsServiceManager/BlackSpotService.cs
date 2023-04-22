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
    public class BlackSpotService : IBlackSpotService
    {
        IBlackSpotRepository _repositiory;
        public BlackSpotService(IBlackSpotRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<BlackSpotMasterEntity> GetAll()
        {
            List<BlackSpotMasterEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
