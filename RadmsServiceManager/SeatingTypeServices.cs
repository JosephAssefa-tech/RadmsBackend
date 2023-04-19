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
    public class SeatingTypeServices : ISeatingTypeServicecs
    {
        ISeatingTypeRepository _repositiory;
        public SeatingTypeServices(ISeatingTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<SeatingTypeLookupEntity> GetAll()
        {
            List<SeatingTypeLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
