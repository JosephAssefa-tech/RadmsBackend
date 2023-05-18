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
        List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? dateTime);
        // IQueryable<SummaryCount> GetFatalCount();
        int GetSeriousCount();
        int GetSlightCount();

        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(VictimDetailsTransactionEntity accident);
        bool Update(VictimDetailsTransactionEntity accident);
        bool Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
        Task<int> GetFatalAccidentCount(int year);
        Task<int> GetSeriousAccidentCount(int year);
        Task<int> GetSlightAccidentCount(int year);
        Task<int> GetPropertyDamageCount(int year);
    }
}
