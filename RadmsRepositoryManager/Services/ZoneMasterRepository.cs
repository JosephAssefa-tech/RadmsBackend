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
    public class ZoneMasterRepository : IZoneMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<ZoneMasterEntity> GetAll(string language)
        {
            List<ZoneMaster> models;

            if (language == "amharic")
            {
                models = context.ZoneMasters.Select(x => new ZoneMaster
                {
                    ZoneId = x.ZoneId,
                    ZoneName = x.ZoneNameAm
                }).ToList();

            }
            else
            {
                models = context.ZoneMasters.Select(x => new ZoneMaster
                {
                    ZoneId = x.ZoneId,
                    ZoneName = x.ZoneName
                }).ToList();
            }
            List<ZoneMasterEntity> entities = new List<ZoneMasterEntity>();
            foreach (var model in models)
            {

                ZoneMasterEntity entity = new ZoneMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
