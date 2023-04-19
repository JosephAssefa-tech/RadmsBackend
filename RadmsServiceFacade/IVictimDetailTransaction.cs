using RadmsDataModels.Models;
using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IVictimDetailTransaction
    {
        VictimDetailsTransactionEntity GetById(int id);
        Task<IEnumerable<SummaryCount>> GetGroupedDataAsync();

        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(VictimDetailsTransactionEntity victim);
        string Update(VictimDetailsTransactionEntity victim);
        string Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
    }
}
