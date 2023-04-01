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
    public class WoredaMasterRepository : IWoredaMasterRepository
    {
        RadmsContext context = new RadmsContext();
    public List<WoredaMasterEntity> GetAll()
    {
            List<WoredaMaster> models = context.WoredaMasters.
                 Include(x => x.Zone).ThenInclude(r=>r.Region)

                .ToList();
            List<WoredaMasterEntity> entities = new List<WoredaMasterEntity>();
            foreach (var model in models)
            {

                WoredaMasterEntity entity = new WoredaMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
