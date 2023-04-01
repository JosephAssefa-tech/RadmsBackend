using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade.Generic
{
    public interface IGenericService<T> where T : class
    {
        bool Save(T entity);
        bool Update(T entity);
        bool Delete(decimal id);
        List<T> GetAll();
        T GetById(int id);
        T FilterByAccidentName(string CauseName);
    }
}
