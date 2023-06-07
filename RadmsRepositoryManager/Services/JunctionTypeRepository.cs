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
    public class JunctionTypeRepository : IJunctionTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int junctionTypeId)
        {
            try
            {
                var result = context.JunctionTypeLookups.Where(x => x.JunctionTypeId == junctionTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.JunctionTypeLookups.Remove(result);
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

        public List<JunctionTypeLookupEntity> GetAll(string language)
        {
            List<JunctionTypeLookup> models;

            if (language == "amharic")
            {
                models = context.JunctionTypeLookups.Select(x => new JunctionTypeLookup
                {
                    JunctionTypeId = x.JunctionTypeId,
                    JunctionTypeName = x.JunctionTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.JunctionTypeLookups.Select(x => new JunctionTypeLookup
                {
                    JunctionTypeId = x.JunctionTypeId,
                    JunctionTypeName = x.JunctionTypeName,
                }).ToList();
            }



            List<JunctionTypeLookupEntity> entities = new List<JunctionTypeLookupEntity>();
            foreach (var model in models)
            {

                JunctionTypeLookupEntity entity = new JunctionTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(JunctionTypeLookupEntity entity)
        {
            try
            {
                JunctionTypeLookup model = entity.MapToModel<JunctionTypeLookup>();


                context.JunctionTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(JunctionTypeLookupEntity entity)
        {
            try
            {
                JunctionTypeLookup old = context.JunctionTypeLookups.Find(entity.JunctionTypeId);
                if (old != null)
                {
                    old.JunctionTypeId = entity.JunctionTypeId;
                    old.JunctionTypeName = entity.JunctionTypeName;
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
