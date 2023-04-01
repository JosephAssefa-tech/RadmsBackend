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
    public class SpeedLimitService : ISpeedLimitService
    {
        ISpeedLimitRepository _repository;
        public SpeedLimitService(ISpeedLimitRepository repository)
        {
            _repository = repository;
        }
        public List<SpeedLimitLookupEntity> GetAll()
        {
            List<SpeedLimitLookupEntity> results = this._repository.GetAll();
            return results;
        }
    }
}
