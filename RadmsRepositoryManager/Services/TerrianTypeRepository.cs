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
    public class TerrianTypeRepository : ITerrianTypeRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int terrianTypeId)
        {
            try
            {
                var result = context.TerrainTypeLookups.Where(x => x.TerrianTypeId == terrianTypeId).FirstOrDefault();
                if (result != null)
                {
                    context.TerrainTypeLookups.Remove(result);
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

        public List<TerrainTypeLookupEntity> GetAll(string? language)
        {
            List<TerrainTypeLookup> models;


            if (language == "amharic")
            {
                models = context.TerrainTypeLookups.Select(x => new TerrainTypeLookup
                {
                   TerrianName = x.TerrianNameAm,
                   TerrianTypeId=x.TerrianTypeId,
                }).ToList();

            }
            else
            {
                models = context.TerrainTypeLookups.Select(x => new TerrainTypeLookup
                {
                    TerrianName = x.TerrianName,
                    TerrianTypeId = x.TerrianTypeId,
                }).ToList();
            }



            List<TerrainTypeLookupEntity> entities = new List<TerrainTypeLookupEntity>();
            foreach (var model in models)
            {

                TerrainTypeLookupEntity entity = new TerrainTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public bool Save(TerrainTypeLookupEntity entity)
        {

            try
            {
                TerrainTypeLookup model = entity.MapToModel<TerrainTypeLookup>();


                context.TerrainTypeLookups.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(TerrainTypeLookupEntity entity)
        {
            try
            {
                TerrainTypeLookup old = context.TerrainTypeLookups.Find(entity.TerrianTypeId);
                if (old != null)
                {
                    old.TerrianTypeId = entity.TerrianTypeId;
                    old.TerrianName = entity.TerrianName;
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
