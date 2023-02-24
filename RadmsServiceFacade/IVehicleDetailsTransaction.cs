using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVehicleDetailsTransaction
    {
        VehicleDetailsTransactionEntity GetById(int id);
        VehicleDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(VehicleDetailsTransactionEntity accident);
        string Update(VehicleDetailsTransactionEntity accident);
        string Delete(decimal id);
        List<VehicleDetailsTransactionEntity> GetAll();

    }
    
}
