using Microsoft.EntityFrameworkCore;
using RadmsDataModels.Models;
using RadmsRepositoryFacade;
using RadmsRepositoryManager.Services.BaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class PaymentTypeRepository : BaseService<PavementTypeLookup>
    {
        public PaymentTypeRepository(DbContext context) : base(context)
        {
        }
        public IEnumerable<PavementTypeLookup> GetByCategory(string category)
        {
            return _dbSet.Where(p => p.PavementName == category).ToList();
        }
    }
}
