using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IVehicleDetailsTransactionRepository
    {
        VehicleDetailsTransactionEntity GetById(int id);
        VehicleDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(VehicleDetailsTransactionEntity accident);
        bool Update(VehicleDetailsTransactionEntity accident);
        bool Delete(decimal id);
        List<VehicleDetailsTransactionEntity> GetAll();

    }
    
}
