using RadmsDataModels.Models;
using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IAccidentDetailsTransaction
    {
        AccidentDetailsTransactionEntity GetById(int id);
        AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName);
       // decimal Save(AccidentDetailsTransactionEntity accident);
        SummaryCount Save(AccidentDetailsTransactionEntity accident);
        int GetTotalAccidentCount();
        string Update(AccidentDetailsTransactionEntity accident);
        string Delete(decimal id);
        List<AccidentDetailsTransactionEntity> GetAll();

    }
}
