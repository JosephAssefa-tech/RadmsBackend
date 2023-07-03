using RadmsDataModels.Modelss;
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
        int GetTotalPropertyDamage(DateTime? startDate, DateTime? endDate);
        int GetTotalAccidentCount(DateTime? startDate,DateTime? endDate);
         
        int GetTotalPropertyDamageOnDashboard(DateTime? startDate,DateTime? endDate);
        bool Update(AccidentDetailsTransactionEntity accident);
        bool Delete(decimal id );
        List<AccidentDetailsTransactionEntity> GetAll(int? regionId, string? language, int? page, int? pageSize);
        List<AccidentDetailsTransactionEntity> FilterAllAcidentForCourtCases(int? RegionID,
            int? ZoneId, int? WoredaId, int? CityId, int? SubCityId, int? Psid, DateTime? FromDate, DateTime? ToDate);
        AccidentDetailsTransactionEntity GetById(int id);
        AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName);
    }
}
