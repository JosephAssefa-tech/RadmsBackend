using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public  interface ILegalMeasurementDetailsTransaction
    {
        LegalMeasurementDetailsTransactionEntity GetById(int id);
        LegalMeasurementDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(LegalMeasurementDetailsTransactionEntity victim);
        string Update(LegalMeasurementDetailsTransactionEntity victim);
        string Delete(decimal id);
        List<LegalMeasurementDetailsTransactionEntity> GetAll();
    }
}
