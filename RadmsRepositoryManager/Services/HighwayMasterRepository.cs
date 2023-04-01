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
    public class HighwayMasterRepository : IHighwayMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HighwayMasterEntity> GetAll()

        {
            List<HighwayMaster> models = context.HighwayMasters.Include(x=>x.Howner)
                .Include(x=>x.Htype)
               .ToList();
            List<HighwayMasterEntity> entities = new List<HighwayMasterEntity>();
            foreach (var model in models)
            {

                HighwayMasterEntity entity = new HighwayMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}

