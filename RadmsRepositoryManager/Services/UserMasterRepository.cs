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
    public class UserMasterRepository : IUserMasterRepository
    {

        RadmsContext context = new RadmsContext();

        public bool Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterEntity> GetAll(string? language)
            {
            List<UserMaster> models;

            if (language == "amharic")
            {
                models = context.UserMasters.
              Include(x => x.Organization).Select(x => new UserMaster
              {
                  UserId = x.UserId,
                  UserName = x.UserName,
                }).ToList();

            }
            else
            {
                models = context.UserMasters.
                Include(x => x.Organization).Select(x => new UserMaster
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                }).ToList();
            }




            List<UserMasterEntity> entities = new List<UserMasterEntity>();
            foreach (var model in models)
            {

                UserMasterEntity entity = new UserMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(UserMasterEntity entity)
        {
            try
            {
                UserMaster model = entity.MapToModel<UserMaster>();


                context.UserMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(UserMasterEntity entity)
        {
            try
            {
                UserMaster old = context.UserMasters.Find(entity.UserId);
                if (old != null)
                {
                    old.UserId = entity.UserId;
                    old.UserName = entity.UserName;
                    context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();

                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
