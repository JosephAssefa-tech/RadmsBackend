using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Models;
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
        public List<BlackSpotMasterEntity> GetAll()
        {
            List<BlackSpotMaster> models = context.BlackSpotMasters.Select(m => new BlackSpotMaster
            {
              
                BlackSpotLat = m.BlackSpotLat,
                BlackSpotLong = m.BlackSpotLong,
                // add any other properties you want to include
            })
                .Distinct()
                .ToList();
            List<BlackSpotMasterEntity> entities = new List<BlackSpotMasterEntity>();
            foreach (var model in models)
            {

                BlackSpotMasterEntity entity = new BlackSpotMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
