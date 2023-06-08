using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsRepositoryManager.Services.BaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int pavementTypeId)
        {
            try
            {
                var result = context.PavementTypeLookups.Where(x => x.PavementTypeId == pavementTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.PavementTypeLookups.Remove(result);
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

        public List<PavementTypeLookupEntity> GetAll(string? language)
        {
            List<PavementTypeLookup> models;
            if (language == "amharic")
            {
                models = context.PavementTypeLookups.Select(x => new PavementTypeLookup
                {
                  PavementName = x.PavementNameAm,
                  PavementTypeId=x.PavementTypeId,
                }).ToList();

            }
            else
            {
                models = context.PavementTypeLookups.Select(x => new PavementTypeLookup
                {
                    PavementName = x.PavementName,
                    PavementTypeId = x.PavementTypeId,
                }).ToList();
            }



            List<PavementTypeLookupEntity> entities = new List<PavementTypeLookupEntity>();
            foreach (var model in models)
            {

                PavementTypeLookupEntity entity = new PavementTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(PavementTypeLookupEntity entity)
        {
            try
            {
                PavementTypeLookup model = entity.MapToModel<PavementTypeLookup>();


                context.PavementTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(PavementTypeLookupEntity entity)
        {
            try
            {
                PavementTypeLookup old = context.PavementTypeLookups.Find(entity.PavementTypeId);
                if (old != null)
                {
                    old.PavementTypeId = entity.PavementTypeId;
                    old.PavementName = entity.PavementName;
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
