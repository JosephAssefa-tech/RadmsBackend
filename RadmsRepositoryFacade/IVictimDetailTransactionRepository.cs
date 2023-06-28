using RadmsDataModels.Modelss;
using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RadmsRepositoryFacade
{
    public interface IVictimDetailTransactionRepository
    {
        VictimDetailsTransactionEntity GetById(int id);
        List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate);
        // IQueryable<SummaryCount> GetFatalCount();
        int GetSeriousCount();
        int GetSlightCount();

        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(VictimDetailsTransactionEntity accident);
        bool Update(VictimDetailsTransactionEntity accident);
        bool Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
        Task<int> GetFatalAccidentCount(int year,DateTime? startDate, DateTime? endDate);
        Task<int> GetSeriousAccidentCount(int year, DateTime? startDate, DateTime? endDate);
        Task<int> GetSlightAccidentCount(int year, DateTime? startDate, DateTime? endDate);
        Task<int> GetPropertyDamageCount(int year, DateTime? startDate, DateTime? endDate);
        Task<CrashValuesEntities> CrashData(DateTime? fromDate, DateTime? toDate);

    }
}
