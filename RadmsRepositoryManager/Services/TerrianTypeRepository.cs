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
        public List<TerrainTypeLookupEntity> GetAll(string language)
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
    }
}
