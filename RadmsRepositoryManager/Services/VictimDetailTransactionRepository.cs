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
        public List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue && !endDate.HasValue)
            {
                // If startDate and endDate are not provided, return all registered data by regionId
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
                        RegionId = regionId.Value,
                        RegionName = context.RegionMasters.FirstOrDefault(r => r.RegionId == regionId)?.RegionName
                    })
                    .ToList();

                return finalResult;
            }
            else
            {
                // If startDate and endDate are provided, apply the date filter
                var result = context.VictimDetailsTransactions
                    .Include(v => v.Severity)
                    .Join(context.AccidentDetailsTransactions,
                        victim => victim.AccidentId,
                        accident => accident.AccidentId,
                        (victim, accident) => new { victim, accident })
                    .Where(va => va.accident.Region.RegionId == regionId &&
                                 va.accident.DateAndTime >= startDate &&
                                 va.accident.DateAndTime <= endDate)
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
                              RegionId = regionId.Value,
                              RegionName = context.RegionMasters.FirstOrDefault(r => r.RegionId == regionId)?.RegionName
                          })
                    .ToList();

                return finalResult;


            }
        }


        //   public List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate)
        //   {

        //       var result = context.VictimDetailsTransactions
        //.Include(v => v.Severity)
        //.Join(context.AccidentDetailsTransactions,
        //    victim => victim.AccidentId,
        //    accident => accident.AccidentId,
        //    (victim, accident) => new { victim, accident })
        //.Where(va => va.accident.Region.RegionId == regionId)
        //.GroupBy(o => new { o.accident.Severity.SeverityId, o.accident.Severity.SeverityType, o.accident.Region.RegionId, o.accident.Region.RegionName })
        //.Select(g => new SummaryData
        //{
        //    SeverityId = g.Key.SeverityId,
        //    SeverityType = g.Key.SeverityType,
        //    Count = g.Count(),
        //    RegionId = (int)g.Key.RegionId,
        //    RegionName = g.Key.RegionName
        //})
        //.ToList();

        //       var severityTypes = context.SeverityLevelLookups.ToList();
        //       var finalResult = severityTypes
        //           .GroupJoin(result,
        //               s => s.SeverityType,
        //               r => r.SeverityType,
        //               (s, r) => new { SeverityType = s, SummaryData = r.FirstOrDefault() })
        //           .Select(x => new SummaryData
        //           {
        //               SeverityId = x.SeverityType.SeverityId,
        //               SeverityType = x.SeverityType.SeverityType,
        //               Count = (x.SummaryData?.Count) ?? 0,
        //              // RegionId = (int)regionId,
        //              // RegionName = x.region.regionName
        //           })
        //           .ToList(); 

        //       return finalResult;


        //   }

        //public async Task<int> GetFatalAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        //{
        //    return await context.VictimDetailsTransactions
        //        .Join(context.AccidentDetailsTransactions,
        //            vdt => vdt.AccidentId,
        //            adt => adt.AccidentId,
        //            (vdt, adt) => new { Vdt = vdt, Adt = adt })
        //             .CountAsync(x => x.Vdt.SeverityId == 2  && x.Adt.DateAndTime.Year == year);

        //    //  .CountAsync(x => x.Vdt.SeverityId == 2 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        //}
        public async Task<int> GetFatalAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            var query = context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                .Where(x => x.Vdt.SeverityId == 2 && x.Adt.DateAndTime.Year == year);

            if (startDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime <= endDate.Value);

            return await query.CountAsync();
        }


        //public async Task<int> GetSeriousAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        //{
        //    return await context.VictimDetailsTransactions
        //        .Join(context.AccidentDetailsTransactions,
        //            vdt => vdt.AccidentId,
        //            adt => adt.AccidentId,
        //            (vdt, adt) => new { Vdt = vdt, Adt = adt })
        //           .CountAsync(x => x.Vdt.SeverityId == 3  && x.Adt.DateAndTime.Year == year);

        //    //  .CountAsync(x => x.Vdt.SeverityId == 3 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        //}
        public async Task<int> GetSeriousAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            var query = context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                .Where(x => x.Vdt.SeverityId == 3 && x.Adt.DateAndTime.Year == year);

            if (startDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime <= endDate.Value);

            return await query.CountAsync();
        }


        //public async Task<int> GetSlightAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        //{
        //    return await context.VictimDetailsTransactions
        //        .Join(context.AccidentDetailsTransactions,
        //            vdt => vdt.AccidentId,
        //            adt => adt.AccidentId,
        //            (vdt, adt) => new { Vdt = vdt, Adt = adt })
        //          .CountAsync(x => x.Vdt.SeverityId == 4  && x.Adt.DateAndTime.Year == year);

        //       // .CountAsync(x => x.Vdt.SeverityId == 4 && x.Adt.SubmissionFlag == 2 && x.Adt.DateAndTime.Year == year);
        //}
        public async Task<int> GetSlightAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            var query = context.VictimDetailsTransactions
                .Join(context.AccidentDetailsTransactions,
                    vdt => vdt.AccidentId,
                    adt => adt.AccidentId,
                    (vdt, adt) => new { Vdt = vdt, Adt = adt })
                .Where(x => x.Vdt.SeverityId == 4 && x.Adt.DateAndTime.Year == year);

            if (startDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(x => x.Adt.DateAndTime <= endDate.Value);

            return await query.CountAsync();
        }


        //public async Task<int> GetPropertyDamageCount(int year, DateTime? startDate, DateTime? endDate)
        //{
        //    return await context.AccidentDetailsTransactions
        //             .CountAsync(x => x.SeverityId == 5  && x.DateAndTime.Year == year);

        //    //   .CountAsync(x => x.SeverityId == 5 && x.SubmissionFlag == 2 && x.DateAndTime.Year == year);
        //}
        public async Task<int> GetPropertyDamageCount(int year, DateTime? startDate, DateTime? endDate)
        {
            var query = context.AccidentDetailsTransactions
                .Where(x => x.SeverityId == 5 && x.DateAndTime.Year == year);

            if (startDate.HasValue)
                query = query.Where(x => x.DateAndTime >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(x => x.DateAndTime <= endDate.Value);

            return await query.CountAsync();
        }
        // the below code is for crash
        // Infrastructure Layer
      

            public async Task<CrashValuesEntities> CrashData(DateTime? fromDate, DateTime? toDate)
            {
                var crashValues = new CrashValuesEntities();

                var crashDatas = await (
                    from vdt in context.VictimDetailsTransactions
                    join adt in context.AccidentDetailsTransactions on vdt.AccidentId equals adt.AccidentId
                    join sll in context.SeverityLevelLookups on vdt.SeverityId equals sll.SeverityId
                    //the below submissionflag need to be 2 change it when the user module done
                    //  where adt.SubmissionFlag == 2 && adt.DateAndTime >= fromDate && adt.DateAndTime <= toDate
                     where  adt.DateAndTime >= fromDate && adt.DateAndTime <= toDate
                    orderby adt.AccidentId descending
                    select new
                    {
                        adt.AccidentId,
                        sll.SeverityId
                    }
                ).ToListAsync();

                foreach (var crashData in crashDatas)
                {
                    int? localFatalCrash = 0;
                    int? localSeriousCrash = 0;
                    int? localSlightCrash = 0;

                    var victimDatas = await context.VictimDetailsTransactions
                        .Where(victim => victim.AccidentId == crashData.AccidentId)
                        .ToListAsync();

                    foreach (var victimData in victimDatas)
                    {
                        if (victimData.SeverityId == 2)
                        {
                            localFatalCrash = 1;
                            localSeriousCrash = 0;
                            localSlightCrash = 0;
                        }
                        else if (victimData.SeverityId == 3)
                        {
                            localFatalCrash = 0;
                            localSeriousCrash = 1;
                            localSlightCrash = 0;
                        }
                        else if (victimData.SeverityId == 4)
                        {
                            localFatalCrash = 0;
                            localSeriousCrash = 0;
                            localSlightCrash = 1;
                        }
                    }

                    crashValues.FatalCrash += localFatalCrash.GetValueOrDefault();
                    crashValues.SeriousCrash += localSeriousCrash.GetValueOrDefault();
                    crashValues.SlightCrash += localSlightCrash.GetValueOrDefault();
                }

                return crashValues;
            }

     
    }
}
