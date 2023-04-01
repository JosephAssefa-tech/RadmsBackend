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
    public class TerrianTypeRepository : ITerrianTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<TerrainTypeLookupEntity> GetAll()
        {
            List<TerrainTypeLookup> models = context.TerrainTypeLookups
             .ToList();
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
