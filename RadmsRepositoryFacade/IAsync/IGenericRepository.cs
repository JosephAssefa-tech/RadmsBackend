using RadmsEntities;
using RadmsRepositoryFacade.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade.IAsync
{
    public interface IGenericRepository<T> where T: class
    {
        bool Save(T entity);
        bool Update(T entity);
        bool Delete(decimal id);
        List<T> GetAll();
        T GetById(int id);
        T FilterByAccidentName(string CauseName);
        //Task<T> GetByIdAsync(int id);
        //Task<IReadOnlyList<T>> GetAllAsync();
        //Task<T> GetWithSpec(ISpecification<T> spec);
        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);


    }
}
