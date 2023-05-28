using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsRepositoryManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class VictimDetailTransactionRepository : IVictimDetailTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<VictimDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public IQueryable<SummaryCount> GetFatalCount()
        //{
        //    var result = context.VictimDetailsTransactions.ToList();
        //    var counts = result.GroupBy(x => x.EmploymentStatus)
        //        .Select(s => new SummaryCount
        //        {
        //            Severity = s.Key,
        //            Count = s.Count()

        //        }).ToList();

        //    return (IQueryable<SummaryCount>)counts;
        //}

        public int GetSeriousCount()
        {
            throw new NotImplementedException();
        }

        public int GetSlightCount()
        {
            throw new NotImplementedException();
        }

        public bool Save(VictimDetailsTransactionEntity victm)
        {
            try
            {
                //CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                //var b = a.GetLastNumberFromDatabase();
                //var c = b;

                VictimDetailsTransaction model = victm.MapToModel<VictimDetailsTransaction>();
              //  model.AccidentId = c;
                context.VictimDetailsTransactions.Add(model);

                context.SaveChanges();

                var result = model.VictimId;
                if (victm.AccidentId != model.AccidentId)
                {

                }
                else if(victm.AccidentId==model.AccidentId)
                {

                }



                return true;
            }
            catch (Exception msg)
            {
                return false;
            }
        }

        public bool Update(VictimDetailsTransactionEntity accident)
        {
        //    var groupedData = await _otherClassRepository.Query()
        //      .Include(o => o.Severity)
        //      .GroupBy(o => new { o.Severity.SeverityId, o.Severity.SeverityType })
        //      .Select(g => new SummaryData
        //      {
        //            // Year=g.Key
        //          SeverityId = g.Key.SeverityId,
        //          SeverityType = g.Key.SeverityType,
        //          Count = g.Count()
        //      })
        //      .ToListAsync();

        //    return groupedData;
        throw new NotImplementedException();
    }
        public List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? dateTime)
        {

            var result = context.VictimDetailsTransactions
     .Include(v => v.Severity)
     .Join(context.AccidentDetailsTransactions,
         victim => victim.AccidentId,
         accident => accident.AccidentId,
         (victim, accident) => new { victim, accident })
     .Where(va => va.accident.Region.RegionId == regionId)
     .GroupBy(o => new { o.accident.Severity.SeverityId, o.accident.Severity.SeverityType, o.accident.Region.RegionId, o.accident.Region.RegionName })
     .Select(g => new SummaryData
     {
         SeverityId = g.Key.SeverityId,
         SeverityType = g.Key.SeverityType,
         Count = g.Count(),
         RegionId = (int)g.Key.RegionId,
         RegionName = g.Key.RegionName
     })
     .ToList();

            var severityTypes = context.SeverityLevelLookups.ToList();
            var finalResult = severityTypes
                .GroupJoin(result,
                    s => s.SeverityType,
                    r => r.SeverityType,
                    (s, r) => new { SeverityType = s, SummaryData = r.FirstOrDefault() })
                .Select(x => new SummaryData
                {
                    SeverityId = x.SeverityType.SeverityId,
                    SeverityType = x.SeverityType.SeverityType,
                    Count = (x.SummaryData?.Count) ?? 0,
                   // RegionId = (int)regionId,
                   // RegionName = x.region.regionName
                })
                .ToList(); 

            return finalResult;


        }

        public async Task<int> GetFatalAccidentCount(int year)
        {
            return await context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                     .CountAsync(x => x.Vdt.SeverityId == 2  && x.Adt.DateAndTime.Year == year);

            //  .CountAsync(x => x.Vdt.SeverityId == 2 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        }

        public async Task<int> GetSeriousAccidentCount(int year)
        {
            return await context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                   .CountAsync(x => x.Vdt.SeverityId == 3  && x.Adt.DateAndTime.Year == year);

            //  .CountAsync(x => x.Vdt.SeverityId == 3 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        }

        public async Task<int> GetSlightAccidentCount(int year)
        {
            return await context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                  .CountAsync(x => x.Vdt.SeverityId == 4  && x.Adt.DateAndTime.Year == year);
   
               // .CountAsync(x => x.Vdt.SeverityId == 4 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        }

        public async Task<int> GetPropertyDamageCount(int year)
        {
            return await context.AccidentDetailsTransactions
                     .CountAsync(x => x.SeverityId == 5  && x.DateAndTime.Year == year);

            //   .CountAsync(x => x.SeverityId == 5 && x.SubmissionFlag == 2 && x.DateAndTime.Year == year);
        }
    }
}
