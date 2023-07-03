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
        public List<ZoneMasterEntity> GetAll(string language, int? regionId)
        {
            IQueryable<ZoneMaster> query = context.ZoneMasters;

            if (regionId.HasValue)
            {
                query = query.Where(x => x.RegionId == regionId.Value);
            }

            List<ZoneMaster> models;

            if (language == "amharic")
            {
                models = query.Select(x => new ZoneMaster
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
                models = query.Select(x => new ZoneMaster
                {
                    ZoneId = x.ZoneId,
                    ZoneName = x.ZoneName,
                    Region = new RegionMaster
                    {
                        RegionName = x.Region.RegionName
                    }
                }).ToList();
            }

            List<ZoneMasterEntity> entities = models.Select(model => new ZoneMasterEntity(model)).ToList();

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
        public bool Delete(int zoneId)
        {
            try
            {
                var result = context.ZoneMasters.Where(x => x.ZoneId == zoneId).FirstOrDefault();
                if (result != null)
                {
                    context.ZoneMasters.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

                // AccidentCauseLookup model = entity.MapToModel<AccidentCauseLookup>();

                // context.AccidentCauseLookups.Remove(model);
                // context.SaveChanges();
                // return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(ZoneMasterEntity entity)
        {
            try
            {
                ZoneMaster old = context.ZoneMasters.Find(entity.ZoneId);
                if (old != null)
                {
                    old.ZoneId = entity.ZoneId;
                    old.ZoneName = entity.ZoneName;
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
