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
    }
}
