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
    public class CityMasterRepository : ICityMasterRepository
    {
        RadmsContext context = new RadmsContext();

        public bool Delete(int cityId)
        {
            try
            {
                var result = context.CityMasters.Where(x => x.CityId == cityId).FirstOrDefault();
                if (result != null)
                {
                    context.CityMasters.Remove(result);
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

        public List<CityMasterEntity> GetAll(string language)
        {
            List<CityMaster> models;
            if (language == "amharic")
            {
                models = context.CityMasters.Select(x => new CityMaster
                {
                    CityId = x.CityId,
                    CityName = x.CityNameAm,
                    Woreda = new WoredaMaster
                    {
                        WoredaName = x.Woreda.WoredaNameAm
                    }
                }).ToList();

            }
            else
            {
                models = context.CityMasters.Select(x => new CityMaster
                {
                    CityId = x.CityId,
                    CityName = x.CityName,
                    Woreda = new WoredaMaster
                    {
                    WoredaName = x.Woreda.WoredaName
                    }
                }).ToList();
            }



            List<CityMasterEntity> entities = new List<CityMasterEntity>();
            foreach (var model in models)
            {

                CityMasterEntity entity = new CityMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Save(CityMasterEntity city, string? selectedLanguage)
        {
            try
            {
                CityMaster model = city.MapToModel<CityMaster>();

                // Set the data based on the selected language
                if (selectedLanguage == "English")
                {
                    model.CityName = city.CityName;
                }
                else if (selectedLanguage == "amharic")
                {
                    model.CityNameAm = city.CityName;
                }
                else if (selectedLanguage == "afanoromo")
                {
                    model.CityNameOr = city.CityName;
                }
                else if (selectedLanguage == "somalia")
                {
                    model.CityNameSo = city.CityName;
                }
                else if (selectedLanguage == "tigray")
                {
                    model.CityNameTi = city.CityName;
                }
                // Add more conditions for other languages if needed



                context.CityMasters.Add(model);
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
