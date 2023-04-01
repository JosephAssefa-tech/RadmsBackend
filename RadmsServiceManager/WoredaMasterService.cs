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
    public class WoredaMasterService : IWoredaMasterService
    {

        IWoredaMasterRepository _repositiory;
        public WoredaMasterService(IWoredaMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<WoredaMasterEntity> GetAll()
        {
            List<WoredaMasterEntity> results = this._repositiory.GetAll();
            return results;
        }

     
    }
}
