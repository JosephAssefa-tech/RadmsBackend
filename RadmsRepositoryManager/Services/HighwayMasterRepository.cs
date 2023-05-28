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
    public class HighwayMasterRepository : IHighwayMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<HighwayMasterEntity> GetAll(string language)

        {
            List<HighwayMaster> models;
            if (language == "amharic")
            {
                models = context.HighwayMasters.Select(x => new HighwayMaster
                {
                    Hid = x.Hid,
                    Hname = x.HnameAm
                }).ToList();

            }
            else
            {
                models = context.HighwayMasters.Select(x => new HighwayMaster
                {
                    Hid = x.Hid,
                    Hname = x.Hname
                }).ToList();
            }


            List<HighwayMasterEntity> entities = new List<HighwayMasterEntity>();
            foreach (var model in models)
            {

                HighwayMasterEntity entity = new HighwayMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}

