using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsRepositoryManager.Services.BaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        RadmsContext context = new RadmsContext();
        public List<PavementTypeLookupEntity> GetAll()
        {
            List<PavementTypeLookup> models = context.PavementTypeLookups
             .ToList();
            List<PavementTypeLookupEntity> entities = new List<PavementTypeLookupEntity>();
            foreach (var model in models)
            {

                PavementTypeLookupEntity entity = new PavementTypeLookupEntity(model);

                entities.Add(entity);
            }
            return entities;
        }
        //public PaymentTypeRepository(DbContext context) : base(context)
        //{
        //}
        //public IEnumerable<PavementTypeLookup> GetByCategory(string category)
        //{
        //    return _dbSet.Where(p => p.PavementName == category).ToList();
        //}
   
    }
}
