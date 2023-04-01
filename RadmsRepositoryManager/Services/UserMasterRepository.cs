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
    public class UserMasterRepository : IUserMasterRepository
    {

        RadmsContext context = new RadmsContext();
            public List<UserMasterEntity> GetAll()
            {
            List<UserMaster> models = context.UserMasters.
              Include(x => x.Organization)
             .ToList();
            List<UserMasterEntity> entities = new List<UserMasterEntity>();
            foreach (var model in models)
            {

                UserMasterEntity entity = new UserMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
