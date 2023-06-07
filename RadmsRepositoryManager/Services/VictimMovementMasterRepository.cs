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
    public class VictimMovementMasterRepository : IVictimMovementMasterRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int victimMovementId)
        {
            try
            {
                var result = context.VictimMovementMasters.Where(x => x.VictimMovementId == victimMovementId).FirstOrDefault();
                if (result != null)
                {
                    context.VictimMovementMasters.Remove(result);
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

        public List<VictimMovementMasterEntity> GetAll(string? language)
        {
            List<VictimMovementMaster> models;
            if(language == "amharic")
            {
                models =     context.VictimMovementMasters.Select(x=> new VictimMovementMaster
                {
                    VictimMovementId = x.VictimMovementId,
                    VictimMovementType = x.VictimMovementTypeAm,
                })
      .ToList();

            }
            else
            {
                models = context.VictimMovementMasters.Select(x => new VictimMovementMaster
                {
                    VictimMovementId = x.VictimMovementId,
                    VictimMovementType = x.VictimMovementType,
                })
   .ToList();

            }
            
        
            List<VictimMovementMasterEntity> entities = new List<VictimMovementMasterEntity>();
            foreach (var model in models)
            {

                VictimMovementMasterEntity entity = new VictimMovementMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(VictimMovementMasterEntity entity)
        {
            try
            {
                VictimMovementMaster model = entity.MapToModel<VictimMovementMaster>();


                context.VictimMovementMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VictimMovementMasterEntity entity)
        {
            try
            {
                VictimMovementMaster old = context.VictimMovementMasters.Find(entity.VictimMovementId);
                if (old != null)
                {
                    old.VictimMovementId = entity.VictimMovementId;
                    old.VictimMovementType = entity.VictimMovementType;
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
