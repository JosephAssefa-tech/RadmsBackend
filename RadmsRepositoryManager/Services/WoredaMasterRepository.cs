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
    public class WoredaMasterRepository : IWoredaMasterRepository
    {
        RadmsContext context = new RadmsContext();
    public List<WoredaMasterEntity> GetAll(string language)
    {
            List<WoredaMaster> models;
            if (language == "amharic")
            {
                models = context.WoredaMasters.Select(x => new WoredaMaster
                {
                   WoredaId=x.WoredaId,
                   WoredaName=x.WoredaNameAm,
                    Zone = new ZoneMaster
                    {
                        ZoneName = x.Zone.ZoneNameAm
                    }
            }).ToList();

            }
            else
            {
                models = context.WoredaMasters.Select(x => new WoredaMaster
                {
                    WoredaId = x.WoredaId,
                    WoredaName = x.WoredaName,
                    Zone = new ZoneMaster
                    {
                        ZoneName = x.Zone.ZoneName
                    }
                }).ToList();
            }




            List<WoredaMasterEntity> entities = new List<WoredaMasterEntity>();
            foreach (var model in models)
            {

                WoredaMasterEntity entity = new WoredaMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }

        public string Save(WoredaMasterEntity entity, string selectedLanguage)
        {
            try
            {
                WoredaMaster model = entity.MapToModel<WoredaMaster>();
                // Set the data based on the selected language
                if (selectedLanguage == "English")
                {
                    model.WoredaName = entity.WoredaName;
                }
                else if (selectedLanguage == "amharic")
                {
                    model.WoredaNameAm = entity.WoredaName;
                }
                else if (selectedLanguage == "afanoromo")
                {
                    model.WoredaNameOr = entity.WoredaName;
                }
                else if (selectedLanguage == "somalia")
                {
                    model.WoredaNameSo = entity.WoredaName;
                }
                else if (selectedLanguage == "tigray")
                {
                    model.WoredaNameTi = entity.WoredaName;
                }

                context.WoredaMasters.Add(model);
                context.SaveChanges();
                return "saved";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int woredaId)
        {
            try
            {
                var result = context.WoredaMasters.Where(x => x.WoredaId == woredaId).FirstOrDefault();
                if (result != null)
                {
                    context.WoredaMasters.Remove(result);
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
    }
}
