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
    public class VictimTypeLookupRepository : IVictimTypeLookupRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int victimTypeId)
        {
            try
            {
                var result = context.VictimTypeLookups.Where(x => x.VictimTypeId == victimTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.VictimTypeLookups.Remove(result);
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

        public List<VictimTypeLookupEntity> GetAll(string? language)
        {
            List<VictimTypeLookup> models;


            if (language == "amharic")
            {
                models = context.VictimTypeLookups.Select(x => new VictimTypeLookup
                {
                    VictimTypeId = x.VictimTypeId,
                    VictimType = x.VictimTypeAm,
                }).ToList();

            }
            else
            {
                models = context.VictimTypeLookups.Select(x => new VictimTypeLookup
                {
                    VictimTypeId = x.VictimTypeId,
                    VictimType = x.VictimType,
                }).ToList();
            }



            List<VictimTypeLookupEntity> entities = new List<VictimTypeLookupEntity>();
            foreach (var model in models)
            {

                VictimTypeLookupEntity entity = new VictimTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(VictimTypeLookupEntity entity)
        {
            try
            {
                VictimTypeLookup model = entity.MapToModel<VictimTypeLookup>();


                context.VictimTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(VictimTypeLookupEntity entity)
        {

            try
            {
                VictimTypeLookup old = context.VictimTypeLookups.Find(entity.VictimTypeId);
                if (old != null)
                {
                    old.VictimTypeId = entity.VictimTypeId;
                    old.VictimType = entity.VictimType;
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
