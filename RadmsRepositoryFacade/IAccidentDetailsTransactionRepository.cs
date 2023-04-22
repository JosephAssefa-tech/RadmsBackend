using RadmsDataModels.Models;
using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IAccidentDetailsTransactionRepository
    {
        //  decimal SaveAsync(AccidentDetailsTransactionEntity accident);
        SummaryData SaveAsync(AccidentDetailsTransactionEntity accident);
        int GetTotalAccidentCount();
        bool Update(AccidentDetailsTransactionEntity accident);
        bool Delete(decimal id );
        List<AccidentDetailsTransactionEntity> GetAll();
        AccidentDetailsTransactionEntity GetById(int id);
        AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName);
    }
}
