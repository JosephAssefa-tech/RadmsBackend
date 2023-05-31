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
    public class SubCityRepository : ISubCityRepository
    {
        RadmsContext context = new RadmsContext();
        public List<SubCityMasterEntity> GetAll(string language)
        {
            List<SubCityMaster> models;
            if (language == "amharic")
            {
                models = context.SubCityMasters.Select(x => new SubCityMaster
                {
                    SubCityId = x.SubCityId,
                    SubCityName = x.SubCityNameAm,
                    City = new CityMaster
                    {
                        CityName = x.City.CityNameAm
                    }
                }).ToList();

            }
            else
            {
                models = context.SubCityMasters.Select(x => new SubCityMaster
                {
                    SubCityId = x.SubCityId,
                    SubCityName = x.SubCityName,
                    City = new CityMaster
                    {
                        CityName = x.City.CityName
                    }

                }).ToList();
            }




            List<SubCityMasterEntity> entities = new List<SubCityMasterEntity>();
            foreach (var model in models)
            {

                SubCityMasterEntity entity = new SubCityMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        public bool Delete(int subcityId)
        {
            try
            {
                var result = context.SubCityMasters.Where(x => x.SubCityId == subcityId).FirstOrDefault();
                if (result != null)
                {
                    context.SubCityMasters.Remove(result);
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

        public bool Save(SubCityMasterEntity subcity, string? selectedLanguage)
        {
            try
            {
                SubCityMaster model = subcity.MapToModel<SubCityMaster>();

                // Set the data based on the selected language
                if (selectedLanguage == "English")
                {
                    model.SubCityName = subcity.SubCityName;
                }
                else if (selectedLanguage == "amharic")
                {
                    model.SubCityNameAm = subcity.SubCityName;
                }
                else if (selectedLanguage == "afanoromo")
                {
                    model.SubCityNameOr = subcity.SubCityName;
                }
                else if (selectedLanguage == "somalia")
                {
                    model.SubCityNameSo = subcity.SubCityName;
                }
                else if (selectedLanguage == "tigray")
                {
                    model.SubCityNameTi = subcity.SubCityName;
                }
                // Add more conditions for other languages if needed



                context.SubCityMasters.Add(model);
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
