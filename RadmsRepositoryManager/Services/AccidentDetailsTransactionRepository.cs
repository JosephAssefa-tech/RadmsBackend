using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Models;
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

        public List<AccidentDetailsTransactionEntity> GetAll()
        {
            //use the below Include function for table that have a relationship to fetch the other table data
            // List<AccidentCauseLookup> models = context.AccidentCauseLookups.Include(x=>x.RelationTable).ToList();

            List<AccidentDetailsTransaction> models = context.AccidentDetailsTransactions.
                Include(x=>x.AccidentType)
                .Include(x=>x.AirCondition)
                .Include(x=>x.CauseofAccident)
                .Include(x=>x.City)
                .Include(x=>x.Woreda)
                .Include(x=>x.Zone)
                .Include(x=>x.Region)
                .Include(x=>x.JunctionType)
                .Include(x=>x.CollisionType)
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
                 //      .Include(e => e.EmployeeOrganization).ThenInclude(o => o.Role)
                // .Include(e => e.EmployeeOrganization).ThenInclude(o => o.Country)

                .ToList();
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

        public  bool SaveAsync(AccidentDetailsTransactionEntity accident)
        {
            try
            {
                AccidentDetailsTransaction model = accident.MapToModel<AccidentDetailsTransaction>();
                context.AccidentDetailsTransactions.Add(model);
     
                context.SaveChanges();

                if (model.AccidentId != 0)
                {
                    CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                    var b = a.GetLastNumberFromDatabase();
                    var c = b;

                }
          




                return true;




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
    }
}
