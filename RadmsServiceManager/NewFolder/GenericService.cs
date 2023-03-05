using RadmsEntities;
using RadmsRepositoryFacade.IAsync;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager.NewFolder
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        IGenericRepository<T> _iservice;
        public GenericService(IGenericRepository<T> iservice)
            {
            this._iservice = iservice;

            }

        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public T FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
