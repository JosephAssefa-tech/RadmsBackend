using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade.Generic
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        //Task<T> GetWithSpec(ISpecification<T> spec);
        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}
