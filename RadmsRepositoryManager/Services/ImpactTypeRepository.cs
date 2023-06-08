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
    public class ImpactTypeRepository : IImpactTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int impactTypeId)
        {
            try
            {
                var result = context.ImpactTypeLookups.Where(x => x.ImpactTypeId == impactTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.ImpactTypeLookups.Remove(result);
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

        public List<ImpactTypeLookupEntity> GetAll(string? language)
        {

            List<ImpactTypeLookup> models;
            if (language == "amharic")
            {
                models = context.ImpactTypeLookups.Select(x => new ImpactTypeLookup
                {
                    ImpactTypeId = x.ImpactTypeId,
                    ImpactTypeName = x.ImpactTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.ImpactTypeLookups.Select(x => new ImpactTypeLookup
                {
                    ImpactTypeId = x.ImpactTypeId,
                    ImpactTypeName = x.ImpactTypeName,
                }).ToList();
            }


            List<ImpactTypeLookupEntity> entities = new List<ImpactTypeLookupEntity>();
            foreach (var model in models)
            {

                ImpactTypeLookupEntity entity = new ImpactTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(ImpactTypeLookupEntity entity)
        {
            try
            {
                ImpactTypeLookup model = entity.MapToModel<ImpactTypeLookup>();


                context.ImpactTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(ImpactTypeLookupEntity entity)
        {
            try
            {
                ImpactTypeLookup old = context.ImpactTypeLookups.Find(entity.ImpactTypeId);
                if (old != null)
                {
                    old.ImpactTypeId = entity.ImpactTypeId;
                    old.ImpactTypeName = entity.ImpactTypeName;
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
