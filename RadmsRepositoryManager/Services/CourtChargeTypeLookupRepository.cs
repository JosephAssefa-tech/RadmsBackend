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
    public class CourtChargeTypeLookupRepository : ICourtChargeTypeLookupRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int courtChargeID)
        {
            try
            {
                var result = context.CourtChargeTypeLookups.Where(x => x.CourtChargeID == courtChargeID).FirstOrDefault();
                if (result != null)
                {
                    context.CourtChargeTypeLookups.Remove(result);
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

        public List<CourtChargeTypeLookupEntity> GetAll(string? language)
        {
            List<CourtChargeTypeLookup> models;
            if (language == "amharic")
            {
                models = context.CourtChargeTypeLookups.Select(x => new CourtChargeTypeLookup
                {
                    CourtChargeID = x.CourtChargeID,
                    CourtChargeType = x.CourtChargeType


                }).ToList();

            }
            else
            {
                models = context.CourtChargeTypeLookups.Select(x => new CourtChargeTypeLookup
                {
                    CourtChargeID = x.CourtChargeID,
                    CourtChargeType = x.CourtChargeType
                }).ToList();
            }
            List<CourtChargeTypeLookupEntity> entities = new List<CourtChargeTypeLookupEntity>();
            foreach (var model in models)
            {

                CourtChargeTypeLookupEntity entity = new CourtChargeTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(CourtChargeTypeLookupEntity entity)
        {
            try
            {
                CourtChargeTypeLookup model = entity.MapToModel<CourtChargeTypeLookup>();


                context.CourtChargeTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public bool Update(CourtChargeTypeLookupEntity entity)
        {
            try
            {
                CourtChargeTypeLookup old = context.CourtChargeTypeLookups.Find(entity.CourtChargeID);
                if (old != null)
                {
                    old.CourtChargeID = entity.CourtChargeID;
                    old.CourtChargeType = entity.CourtChargeType;
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
