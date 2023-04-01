using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ILegalMeasurementDetailsTransactionRepository
    {
        LegalMeasurementDetailsTransactionEntity GetById(int id);
        LegalMeasurementDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(LegalMeasurementDetailsTransactionEntity accident);
        bool Update(LegalMeasurementDetailsTransactionEntity accident);
        bool Delete(decimal id);
        List<LegalMeasurementDetailsTransactionEntity> GetAll();
    }
}
