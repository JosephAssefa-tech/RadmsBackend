using Microsoft.EntityFrameworkCore;
using RadmsRepositoryFacade.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Evaluator
{
    public class SpecificationEvaluator<T> where T: class
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery,
            ISpecification<T> spec)
        {
            var query = inputQuery;
            if(spec.Criteria!=null)
            {
                query = query.Where(spec.Criteria);//p=>p.accidentTypeId==id
            }
            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
            return query;
        }
    }
}
