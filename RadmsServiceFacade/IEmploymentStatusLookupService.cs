using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
   public interface IEmploymentStatusLookupService
    {
        string Save(EmploymentStatusLookupEntity entity);
        string Update(EmploymentStatusLookupEntity entity);
        string Delete(int employmentStatusId);
        List<EmploymentStatusLookupEntity> GetAll(string? language);
    }
}
