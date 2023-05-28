using RadmsRepositoryFacade.BaseRepositoryFacade;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager.NewFolder
{
    public class BaseServicee<T> : IBaseServicee<T> where T : class
    {
        IBaseRepoFacade<T> _baseRepo;
        public BaseServicee(IBaseRepoFacade<T> baseRepo)
        {
            _baseRepo = baseRepo;

        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
