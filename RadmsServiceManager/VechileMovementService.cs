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
    public class VechileMovementService : IVechileMovementService
    {
        public IVechileMovementRespository _repositiory;
        public VechileMovementService(IVechileMovementRespository repository)
        {
            this._repositiory = repository;
        }
        public List<VehicleMovementMasterEntity> GetAll()
        {
            List<VehicleMovementMasterEntity> results = this._repositiory.GetAll();
            return results;
        }
    }
}
