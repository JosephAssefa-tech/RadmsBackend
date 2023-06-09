using RadmsDataAccessLogic;
using RadmsRepositoryFacade.BaseRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.BaseRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RadmsContext _dbContext;

        public Repository(RadmsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> Query()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }
    }
}

