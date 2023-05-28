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
                    ZoneName = x.ZoneNameAm,
                    Region = new RegionMaster
                    {
                        RegionName = x.Region.RegionNameAm
                    }
                }).ToList();

            }
            else
            {
                models = context.ZoneMasters.Select(x => new ZoneMaster
                {
                    ZoneId = x.ZoneId,
                    ZoneName = x.ZoneName,
                    Region = new RegionMaster
                    {
                        RegionName = x.Region.RegionName
                    }
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

        public bool Save(ZoneMasterEntity entity, string? selectedLanguage)
        {
            try
            {
                ZoneMaster model = entity.MapToModel<ZoneMaster>();

                // Set the data based on the selected language
                if (selectedLanguage == "English")
                {
                    model.ZoneName = entity.ZoneName;
                }
                else if (selectedLanguage == "amharic")
                {
                    model.ZoneNameAm = entity.ZoneName;
                }
                else if (selectedLanguage == "afanoromo")
                {
                    model.ZoneNameOr = entity.ZoneName;
                }
                else if (selectedLanguage == "somalia")
                {
                    model.ZoneNameSo = entity.ZoneName;
                }
                else if (selectedLanguage == "tigray")
                {
                    model.ZoneNameTi = entity.ZoneName;
                }
                // Add more conditions for other languages if needed



                context.ZoneMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
