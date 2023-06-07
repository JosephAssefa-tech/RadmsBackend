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

        public bool Delete(string hid)
        {
            try
            {
                var result = context.HighwayMasters.Where(x => x.Hid == hid).FirstOrDefault();
                if (result != null)
                {
                    context.HighwayMasters.Remove(result);
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

        public List<HighwayMasterEntity> GetAll(string? language)

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

        public bool Save(HighwayMasterEntity entity)
        {
            try
            {
                HighwayMaster model = entity.MapToModel<HighwayMaster>();


                context.HighwayMasters.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(HighwayMasterEntity entity)
        {
            try
            {
                HighwayMaster old = context.HighwayMasters.Find(entity.Hid);
                if (old != null)
                {
                    old.Hid = entity.Hid;
                    old.Hname = entity.Hname;
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

