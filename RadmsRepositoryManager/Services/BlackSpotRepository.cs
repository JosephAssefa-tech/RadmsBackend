using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class BlackSpotRepository : IBlackSpotRepository
    {
        RadmsContext context = new RadmsContext();
        public List<BlackSpotMasterEntity> GetAll(DateTime? startDate, DateTime? endDate)
        {
            IQueryable<BlackSpotMaster> query = context.BlackSpotMasters;

            if (startDate != null && endDate != null)
            {
                query = query.Join(context.AccidentDetailsTransactions,
                                    blackspot => blackspot.AccidentId,
                                    accident => accident.AccidentId,
                                    (blackspot, accident) => new { BlackSpot = blackspot, Accident = accident })
                             .Where(joinResult => joinResult.Accident.DateAndTime >= startDate && joinResult.Accident.DateAndTime <= endDate)
                             .Select(joinResult => joinResult.BlackSpot);
            }

            List<BlackSpotMaster> models = query.Distinct().ToList();
            List<BlackSpotMasterEntity> entities = models.Select(model => new BlackSpotMasterEntity(model)).ToList();
            return entities;
        }

        public int GetBlackspotCount()
        {
            var totalCount = context.BlackSpotMasters
                
                .Distinct()
                .Count();
            return totalCount;
        }
    }
}
