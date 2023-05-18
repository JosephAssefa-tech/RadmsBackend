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
                    SubCityName = x.SubCityNameAm
                }).ToList();

            }
            else
            {
                models = context.SubCityMasters.Select(x => new SubCityMaster
                {
                    SubCityId = x.SubCityId,
                    SubCityName = x.SubCityName
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
    }
}
