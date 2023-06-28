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
    public class OrganizationMasterRepository : IOrganizationMasterRepository
    {
        RadmsContext context = new RadmsContext();
        public List<OrganizationMasterEntity> GetAll(string? language)
        {
            List<OrganizationMaster> models;
            if (language == "amharic")
            {
                models = context.OrganizationMasters.Select(x => new OrganizationMaster
                {
                    OrganizationId = x.OrganizationId,
                    OrganizationName = x.OrganizationName,
                }).ToList();

            }
            else
            {
                models = context.OrganizationMasters.Select(x => new OrganizationMaster
                {
                    OrganizationId = x.OrganizationId,
                    OrganizationName = x.OrganizationName,
                }).ToList();
            }



            List<OrganizationMasterEntity> entities = new List<OrganizationMasterEntity>();
            foreach (var model in models)
            {

                OrganizationMasterEntity entity = new OrganizationMasterEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
    }
}
