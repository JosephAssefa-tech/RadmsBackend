using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IEmploymentStatusLookupRepository
    {
        bool Save(EmploymentStatusLookupEntity entity);
        bool Update(EmploymentStatusLookupEntity entity);
        bool Delete(int employmentStatusId);
        List<EmploymentStatusLookupEntity> GetAll(string? language);
    }
}
