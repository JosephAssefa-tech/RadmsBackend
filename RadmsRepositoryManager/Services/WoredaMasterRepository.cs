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

        public string Save(WoredaMasterEntity entity)
        {
            try
            {
                WoredaMaster model = entity.MapToModel<WoredaMaster>();


                context.WoredaMasters.Add(model);
                context.SaveChanges();
                return "saved";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
