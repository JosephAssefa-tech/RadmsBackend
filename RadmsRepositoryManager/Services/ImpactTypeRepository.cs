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
    public class ImpactTypeRepository : IImpactTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<ImpactTypeLookupEntity> GetAll(string language)
        {

            List<ImpactTypeLookup> models;
            if (language == "amharic")
            {
                models = context.ImpactTypeLookups.Select(x => new ImpactTypeLookup
                {
                    ImpactTypeId = x.ImpactTypeId,
                    ImpactTypeName = x.ImpactTypeNameAm,
                }).ToList();

            }
            else
            {
                models = context.ImpactTypeLookups.Select(x => new ImpactTypeLookup
                {
                    ImpactTypeId = x.ImpactTypeId,
                    ImpactTypeName = x.ImpactTypeName,
                }).ToList();
            }


            List<ImpactTypeLookupEntity> entities = new List<ImpactTypeLookupEntity>();
            foreach (var model in models)
            {

                ImpactTypeLookupEntity entity = new ImpactTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
       
    }
}
