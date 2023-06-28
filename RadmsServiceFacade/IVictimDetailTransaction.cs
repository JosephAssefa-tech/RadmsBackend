using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryManager.Helpers;
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
        List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate);
        Task<IEnumerable<SummaryData>> GetGroupedDataAsync(DateTime? startDate, DateTime? endDate);

        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(VictimDetailsTransactionEntity victim);
        string Update(VictimDetailsTransactionEntity victim);
        string Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
        Task<int> GetFatalAccidentCount(int year, DateTime? startDate, DateTime? endDate);
        Task<int> GetSeriousAccidentCount(int year, DateTime? startDate, DateTime? endDate);
        Task<int> GetSlightAccidentCount(int year, DateTime? startDate, DateTime? endDate);
        Task<int> GetPropertyDamageCount(int year, DateTime? startDate, DateTime? endDate);
        Task<CrashValuesEntities> GetCrashData(DateTime? fromDate, DateTime? toDate);

    }
}
