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
    public class PoliceStationMasterRepository : IPoliceStationMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(string id)
        {
            try
            {
                var result = context.PoliceStationMasters.Where(x => x.Psid == id).FirstOrDefault();
                if (result != null)
                {
                    context.PoliceStationMasters.Remove(result);
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

    public PoliceStationMasterEntity FilterByAccidentName(string CauseName)
        {
        PoliceStationMaster model = context.PoliceStationMasters.Where(x => x.Psname == CauseName).FirstOrDefault();
        return new PoliceStationMasterEntity(model);
          }

        public List<PoliceStationMasterEntity> GetAll()
        {
            List<PoliceStationMaster> models = context.PoliceStationMasters
                 .Include(x => x.Woreda).ThenInclude(z=>z.Zone).ThenInclude(r=>r.Region)
                .Include(s => s.SubCity).ThenInclude(c=>c.City)

                .ToList();
            List<PoliceStationMasterEntity> entities = new List<PoliceStationMasterEntity>();
            foreach (var model in models)
            {

                PoliceStationMasterEntity entity = new PoliceStationMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public PoliceStationMasterEntity GetById(string id)
        {
            PoliceStationMaster model = context.PoliceStationMasters.Where(x => x.Psid == id)
                .Include(x => x.Woreda)
                .Include(x => x.SubCity)
                .FirstOrDefault();
            return new PoliceStationMasterEntity(model);
        }

        public bool Save(PoliceStationMasterEntity entity)
        {
            try
            {
                PoliceStationMaster model = entity.MapToModel<PoliceStationMaster>();


                context.PoliceStationMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(PoliceStationMasterEntity entity)
        {
            try
            {
                PoliceStationMaster old = context.PoliceStationMasters.Find(entity.Psid);
                if (old != null)
                {
                    old.Psid = entity.Psid;
                    old.Psname = entity.Psname;
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
