using RadmsDataModels.Modelss;
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
        List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? dateTime);
        Task<IEnumerable<SummaryData>> GetGroupedDataAsync(DateTime? startDate, DateTime? endDate);

        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(VictimDetailsTransactionEntity victim);
        string Update(VictimDetailsTransactionEntity victim);
        string Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
        Task<int> GetFatalAccidentCount(int year);
        Task<int> GetSeriousAccidentCount(int year);
        Task<int> GetSlightAccidentCount(int year);
        Task<int> GetPropertyDamageCount(int year);
    }
}
