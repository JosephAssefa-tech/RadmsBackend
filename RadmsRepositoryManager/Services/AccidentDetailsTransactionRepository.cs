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
    public class AccidentDetailsTransactionRepository : IAccidentDetailsTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id)
        {
            try
            {
                var result = context.AccidentDetailsTransactions.Where(x => x.AccidentId == id).FirstOrDefault();
                if(result!=null)
                {
                    context.AccidentDetailsTransactions.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            AccidentDetailsTransaction model = context.AccidentDetailsTransactions.Where(x => x.AccidentLocalName == CauseName).FirstOrDefault();
            return new AccidentDetailsTransactionEntity(model);
        }

        public List<AccidentDetailsTransactionEntity> GetAll(int? regionId, string? language, int? page, int? pageSize)
        {
            IQueryable<AccidentDetailsTransaction> query = context.AccidentDetailsTransactions
                .Include(x => x.AccidentType)
                .Include(x => x.AirCondition)
                .Include(x => x.CauseofAccident)
                .Include(x => x.City)
                .Include(x => x.Woreda)
                .Include(x => x.Zone).ThenInclude(r => r.Region)
                .Include(x => x.Region)
                .Include(x => x.JunctionType)
                .Include(x => x.CollisionType)
                .Include(x => x.HidNavigation).ThenInclude(z => z.Howner)
                .Include(x => x.HighwayType)
                .Include(x => x.ImpactType)
                .Include(x => x.JunctionType)
                .Include(x => x.LandmarkType)
                .Include(x => x.LightCondtion)
                .Include(x => x.PavementType)
                .Include(x => x.Ps).ThenInclude(s => s.SubCity)
                .Include(x => x.RoadCarriageway)
                .Include(x => x.RoadSurface)
                .Include(x => x.Severity)
                .Include(x => x.SpeedLimit)
                .Include(x => x.SubCity).ThenInclude(c => c.City).ThenInclude(w => w.Woreda)
                .Include(x => x.TerrianType)
                .Include(x => x.User).ThenInclude(o => o.Organization)
                .Include(x => x.WeatherCond)
                .Include(x => x.Woreda);

            if (regionId.HasValue)
            {
                query = query.Where(x => x.RegionId == regionId);
            }

            if (page.HasValue && pageSize.HasValue)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value) // Skip the previous pages
                             .Take(pageSize.Value); // Take the specified number of records for the current page
            }

            List<AccidentDetailsTransaction> models = query.ToList();
            List<AccidentDetailsTransactionEntity> entities = new List<AccidentDetailsTransactionEntity>();

            foreach (var model in models)
            {
                AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity(model);
                entities.Add(entity);
            }

            return entities;
        }


        public AccidentDetailsTransactionEntity GetById(int id)
        {
            AccidentDetailsTransaction model = context.AccidentDetailsTransactions.Where(x => x.AccidentId == id)
                 .Include(x => x.AccidentType)
                .Include(x => x.AirCondition)
                .Include(x => x.CauseofAccident)
                .Include(x => x.City)
                .Include(x => x.Woreda)
                .Include(x => x.Zone)
                .Include(x => x.Region)
                .Include(x => x.JunctionType)
                .Include(x => x.CollisionType)
                .Include(x => x.HidNavigation)
                .Include(x => x.HighwayType)
                .Include(x => x.ImpactType)
                .Include(x => x.JunctionType)
                .Include(x => x.LandmarkType)
                .Include(x => x.LightCondtion)
                .Include(x => x.PavementType)
                .Include(x => x.Ps)
                .Include(x => x.Region)
                .Include(x => x.RoadCarriageway)
                .Include(x => x.RoadSurface)
                .Include(x => x.Severity)
                .Include(x => x.SpeedLimit)
                .Include(x => x.SubCity)
                .Include(x => x.TerrianType)
                .Include(x => x.User)
                .Include(x => x.WeatherCond)
                .Include(x => x.Woreda)
                .Include(x => x.Zone)
                .FirstOrDefault();
            return new AccidentDetailsTransactionEntity(model);
        }

        //public int GetTotalAccidentCount(DateTime? startDate,DateTime? endDate)
        //{
        //      var totalCount  = context.AccidentDetailsTransactions.Count();
        //    return totalCount;


        //}
        public int GetTotalAccidentCount(DateTime? startDate, DateTime? endDate)
        {
            var query = context.AccidentDetailsTransactions.AsQueryable();

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(a => a.DateAndTime >= startDate && a.DateAndTime <= endDate);
            }

            var totalCount = query.Count();

            if (!startDate.HasValue && !endDate.HasValue)
            {
                // Return total count without date filter as default count value
                return totalCount;
            }

            return totalCount;
        }






        public int GetTotalPropertyDamageOnDashboard(DateTime? startDate, DateTime? endDate)
        {
            var totalPropertyCount = 0;
            //var query = context.AccidentDetailsTransactions.AsQueryable();
            if (startDate!=null && endDate.HasValue!=null)
            {
                totalPropertyCount = context.AccidentDetailsTransactions.
                    Where(x=>x.DateAndTime >= startDate && x.DateAndTime <= endDate).
                    Count(ac => ac.PropertyDamage > 0);


            }
            else
            {
                // Return total count without date filter as default count value
                totalPropertyCount = context.AccidentDetailsTransactions.Count(ac => ac.PropertyDamage > 0);

            }

            return totalPropertyCount;
        }
        public int GetTotalPropertyDamage(DateTime? startDate, DateTime? endDate)
        {
            var totalCount = 0;

            if (startDate != null && endDate != null)
            {
                totalCount = context.AccidentDetailsTransactions
                    .Include(x => x.Severity)
                    .Where(x => x.SeverityId == 5 && x.DateAndTime >= startDate && x.DateAndTime <= endDate)
                    .Count();
            }
            else
            {
                totalCount = context.AccidentDetailsTransactions
                    .Include(x => x.Severity)
                    .Where(x => x.SeverityId == 5)
                    .Count();
            }

            return totalCount;
        }

        public SummaryData SaveAsync(AccidentDetailsTransactionEntity accident)
        {
            try
            {
                int NumberOfMainRoads;
                AccidentDetailsTransaction model = accident.MapToModel<AccidentDetailsTransaction>();
                context.AccidentDetailsTransactions.Add(model);
              
     
                context.SaveChanges();
                var query = from accidentDetail in context.AccidentDetailsTransactions
                            join junctionType in context.JunctionTypeLookups
                                on accidentDetail.JunctionTypeId equals junctionType.JunctionTypeId
                            where accidentDetail.AccidentId==model.AccidentId
                            select junctionType.JunctionNoOfRoads;
                int value =  query.FirstOrDefault();

                if(query==null)
                {
                    NumberOfMainRoads = 0;

                }
                else
                {
                    NumberOfMainRoads = value ;
                }
               

                //if (model.AccidentId != 0)
                //{
                //    CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                //    var b = a.GetLastNumberFromDatabase();
                //    var c = b;

                //}
               var result = model.AccidentId;
                SummaryData sm = new SummaryData
                {
                    AccidentId = result,
                    NumberOfMainRoad = NumberOfMainRoads
                    
                };
                return sm;






                //var now = DateTime.Now;
                //var prefix = now.ToString("yyyyMMddHHmmss");
                //var lastNumber = context.Set<AccidentDetailsTransaction>()
                //    .OrderByDescending(x => x.AccidentId)
                //    .Select(x => x.AccidentId)
                //    .FirstOrDefault();
                //var nextNumber = lastNumber + 1;
                //  var id = $"{prefix}{nextNumber:D6}";
                // AccidentDetailsTransaction model = accident.MapToModel<AccidentDetailsTransaction>();
                //  context.Add(new AccidentDetailsTransaction { AccidentId = nextNumber,

                // });
                // context.SaveChanges();
                //      return id;
                //    return true;

                //    context.Set<AccidentDetailsTransaction>().Add(new AccidentDetailsTransaction { AccidentId = nextNumber });
                //    context.SaveChangesAsync();
                //     return true;
                //            return id;
            }
            catch (Exception)
            {
                 throw;
            }
        }



        public bool Update(AccidentDetailsTransactionEntity accident)
        {
            try
            {
                AccidentDetailsTransaction old = context.AccidentDetailsTransactions.Find(accident.AccidentId);
                old.AccidentId = (decimal)accident.AccidentId;
                old.AccidentLocalName = accident.AccidentLocalName;
                old.Image1=accident.Image1;
                old.Image2=accident.Image2;
                old.Image3=accident.Image3;
                old.Image4=accident.Image4;
                old.Image5=accident.Image5;
                old.Image6=accident.Image6;

                //old.AccidentType = accident.AccidentType;
                context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<AccidentDetailsTransactionEntity> FilterAllAcidentForCourtCases(int? RegionID, int? ZoneId, int? WoredaId, int? CityId, int? SubCityId, int? Psid, DateTime? FromDate, DateTime? ToDate)
        {
            List<AccidentDetailsTransaction> models = context.AccidentDetailsTransactions
                .Include(x => x.AccidentType)
                .Include(x => x.AirCondition) // Add this line to include related property
                .Include(x => x.CauseofAccident)
                .Include(x => x.City)
                .Include(x => x.Woreda)
                .Include(x => x.Zone).ThenInclude(r => r.Region)
                .Include(x => x.Region)
                .Include(x => x.CollisionType)
                .Include(x => x.HidNavigation).ThenInclude(z => z.Howner)
                .Include(x => x.HighwayType)
                .Include(x => x.ImpactType)
                .Include(x => x.JunctionType)// Add this line to include related property
                .Include(x => x.LandmarkType)
                .Include(x => x.LightCondtion)
                .Include(x => x.PavementType)
                .Include(x => x.Ps).ThenInclude(s => s.SubCity)
                .Include(x => x.RoadCarriageway)
                .Include(x => x.RoadSurface)
                .Include(x => x.Severity)
                .Include(x => x.SpeedLimit)
                .Include(x => x.SubCity).ThenInclude(c => c.City).ThenInclude(w => w.Woreda)
                .Include(x => x.TerrianType)
                .Include(x => x.User).ThenInclude(o => o.Organization)
                .Include(x => x.WeatherCond)
                .Include(x => x.Woreda)
                .Where(x => x.RegionId == RegionID && x.ZoneId == ZoneId && x.WoredaId == WoredaId && x.CityId == CityId && x.SubCityId == SubCityId && x.Psid.Equals(Psid))
                .ToList();

            List<AccidentDetailsTransactionEntity> entities = new List<AccidentDetailsTransactionEntity>();
            foreach (var model in models)
            {
                AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity(model);


                entities.Add(entity);
            }
            return entities;
        }


    }
}
